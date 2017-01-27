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
    public partial class AnimalsForm : Form
    {
        private AddAnimalForm addAnimalForm;
        private UpdateAnimalForm updateAnimalForm;
        private string conString = "Server=127.0.0.1;Database=myDB;Uid=root;Pwd=softkitty1";
        private MySqlConnection con;
        private string selectedIndex = "";
        private FoodForm foodForm;
        private WorkersForm workersForm;

        public AnimalsForm()
        {
            InitializeComponent();
            con = new MySqlConnection(conString);
            animalsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            updateAnimalsData();
        }

        private void animalsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void AnimalsForm_Load(object sender, EventArgs e)
        {
           
        }
        public void updateAnimalsData()
        {
            con.Open();
            string query = @"SELECT animals.animalId, animals.class, animals.species, animals.gender, 
                            animals.nickname, animals.age, food.type, workers.surname
                            FROM    animals LEFT JOIN food ON animals.foodType = food.foodId LEFT JOIN
                            workers ON animals.zookeeper = workers.workerId";
            MySqlDataAdapter adap = new MySqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            animalsDataGridView.DataSource = ds.Tables[0].DefaultView;
            foreach (DataGridViewColumn column in animalsDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            animalsDataGridView.Sort(animalsDataGridView.Columns[0], ListSortDirection.Ascending);
            con.Close();
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            foodForm = new FoodForm(this);
            foodForm.MdiParent = this.MdiParent;
            foodForm.Show();
        }

        private void btnShowWorkers_Click(object sender, EventArgs e)
        {
            workersForm = new WorkersForm();
            workersForm.Show();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            addAnimalForm = new AddAnimalForm(this);
            addAnimalForm.Show();
        }

        private void btnDeleteAnimal_Click(object sender, EventArgs e)
        {
            if (selectedIndex != "")
            {
                try
                {
                    string query = "delete from myDB.animals where animalId='" + selectedIndex + "';";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    updateAnimalsData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("You have to choose a row.");
            selectedIndex = "";
        }

        private void btnUpdateAnimal_Click(object sender, EventArgs e)
        {
            updateAnimalForm = new UpdateAnimalForm(this,animalsDataGridView.ColumnCount,
                animalsDataGridView.Rows[animalsDataGridView.SelectedCells[0].RowIndex], 
                getListOfCellsNames(), getListOfFood());
            updateAnimalForm.Show();
        }
        private List<string> getListOfCellsNames()
        {
            List<string> names = new List<string>();
            names.Add("Id");
            names.Add("Class");
            names.Add("Species");
            names.Add("Nickname");
            names.Add("Gender");
            names.Add("Age");
            names.Add("Food");
            names.Add("Zookeeper");
            return names;
        }
        private List<string> getListOfFood()
        {
            List<string> food;
            DataTable dt = numberOfFood();
            food = new List<string>(dt.Rows.Count);
            foreach (DataRow row in dt.Rows)
                food.Add((string)row["type"]);
            return food;
        }
        private DataTable numberOfFood()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM myDB.food", con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        private void animalsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedIndex = animalsDataGridView.SelectedRows.Count.ToString();
        }

        private void animalsDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedIndex = animalsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
