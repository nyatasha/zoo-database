using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DatabaseApp
{
    public partial class UpdateAnimalForm : Form
    {
        private AnimalsForm animalsForm;
        private int numberOfColumns;
        private DataGridViewRow selectedRow;
        private List<string> listOfCellNames;
        private List<string> listOfFood;
        private ComboBox combo = null;

        public UpdateAnimalForm()
        {
            InitializeComponent();
        }
        public UpdateAnimalForm(AnimalsForm form, int numberOfColumns, DataGridViewRow selectedRow, List<string> listOfNames, List<string> listOfFood)
        {
            InitializeComponent();
            this.numberOfColumns = numberOfColumns;
            this.selectedRow = selectedRow;
            this.listOfCellNames = listOfNames;
            this.listOfFood = listOfFood;
            this.animalsForm = form;
        }
        private void UpdateAnimalForm_Load(object sender, EventArgs e)
        {
            this.updateAnimalsDataGridView.ColumnCount = 7;
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(this.updateAnimalsDataGridView);

            for (int i = 0; i < numberOfColumns-1; i++)
                row.Cells[i].Value = selectedRow.Cells[i].Value;

            this.updateAnimalsDataGridView.Rows.Add(row);
            DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
            comboBoxCell.DataSource = listOfFood;
            comboBoxCell.Value = selectedRow.Cells[6].Value;
            this.updateAnimalsDataGridView[6, 0] = comboBoxCell;

            for (int i = 0; i < numberOfColumns-1; i++)
                updateAnimalsDataGridView.Columns[i].HeaderText = listOfCellNames[i];

            this.updateAnimalsDataGridView.Columns[0].ReadOnly = true;
            this.updateAnimalsDataGridView.Columns[1].ReadOnly = true;
            this.updateAnimalsDataGridView.Columns[2].ReadOnly = true;
            this.updateAnimalsDataGridView.Columns[4].ReadOnly = true;
            
            this.updateAnimalsDataGridView.Columns[5].ReadOnly = true;
            
        }

        private void btnSaveUpdated_Click(object sender, EventArgs e)
        {
            int position = -1;
            if (combo != null) position = combo.SelectedIndex + 1;
            try
            {
                string conString = "Server=127.0.0.1;Database=myDB;Uid=root;Pwd=softkitty1";
                MySqlConnection con = new MySqlConnection(conString);

                string query1 = "SET FOREIGN_KEY_CHECKS=0";
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();

                string query = @"update myDB.animals set nickname=@Nickname, foodType=@Food
                                where animalId=@id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                
                con.Open();
                cmd.Parameters.AddWithValue("@Nickname", this.updateAnimalsDataGridView.CurrentRow.Cells[4].Value.ToString());
               
                cmd.Parameters.AddWithValue("@Food", position.ToString());
                cmd.Parameters.AddWithValue("@id", this.updateAnimalsDataGridView.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                con.Close();

                string query2 = "SET FOREIGN_KEY_CHECKS=1";
                MySqlCommand cmd2 = new MySqlCommand(query2, con);
                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            animalsForm.updateAnimalsData();
            this.Close();
        }

        private void updateWorkerDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            combo = e.Control as ComboBox;
        }

        private void btnSaveAnimal_Click(object sender, EventArgs e)
        {

        }
    }
}
