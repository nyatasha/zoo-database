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
    public partial class UpdateWorkerForm : Form
    {
        private WorkersForm workersForm;
        private int numberOfColumns;
        private DataGridViewRow selectedRow;
        private List<string> listOfCellNames;
        private List<string> listOfPositions;
        private ComboBox combo = null;

        public UpdateWorkerForm()
        {
            InitializeComponent();
        }
        public UpdateWorkerForm(WorkersForm form, int numberOfColumns, DataGridViewRow selectedRow, List<string> listOfNames, List<string> listOfPositions)
        {
            InitializeComponent();
            this.numberOfColumns = numberOfColumns;
            this.selectedRow = selectedRow;
            this.listOfCellNames = listOfNames;
            this.listOfPositions = listOfPositions;
            this.workersForm = form;
            //updateWorkerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void UpdateWorkerForm_Load(object sender, EventArgs e)
        {
            this.updateWorkerDataGridView.ColumnCount = 6;
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(this.updateWorkerDataGridView);

            for (int i = 0; i < numberOfColumns-1; i++)
                row.Cells[i].Value = selectedRow.Cells[i].Value;

            this.updateWorkerDataGridView.Rows.Add(row);
            DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
            comboBoxCell.DataSource = listOfPositions;
            comboBoxCell.Value = selectedRow.Cells[5].Value;
            this.updateWorkerDataGridView[5, 0] = comboBoxCell;

            for (int i = 0; i < numberOfColumns-1; i++)
              updateWorkerDataGridView.Columns[i].HeaderText = listOfCellNames[i];

            this.updateWorkerDataGridView.Columns[0].ReadOnly = true;
            this.updateWorkerDataGridView.Columns[1].ReadOnly = true;
            this.updateWorkerDataGridView.Columns[3].ReadOnly = true;
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

                string query = @"update myDB.workers set surname=@Surname, email=@Email, positionId=@pos
                                where workerId=@worker";
                MySqlCommand cmd = new MySqlCommand(query, con);
                
                con.Open();
                cmd.Parameters.AddWithValue("@Surname", this.updateWorkerDataGridView.CurrentRow.Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@Email", this.updateWorkerDataGridView.CurrentRow.Cells[4].Value.ToString());
                cmd.Parameters.AddWithValue("@pos", position.ToString());
                cmd.Parameters.AddWithValue("@worker", this.updateWorkerDataGridView.CurrentRow.Cells[0].Value.ToString());
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
            workersForm.updateWorkersData();
            this.Close();
        }

        private void updateWorkerDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            combo = e.Control as ComboBox;
        }
    }
}
