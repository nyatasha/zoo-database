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
    public partial class WorkersForm : Form
    {
        private AddWorkerForm addWorkerForm;
        private UpdateWorkerForm updateWorkerForm;
        private PositionsForm positionsForm;
        private string conString = "Server=127.0.0.1;Database=myDB;Uid=root;Pwd=softkitty1";
        private MySqlConnection con;
        private string selectedIndex = "";

        public WorkersForm()
        {
            InitializeComponent();
            con = new MySqlConnection(conString);
            updateWorkersData();
            workersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private DataTable numberOfPositions()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM myDB.positions", con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            addWorkerForm = new AddWorkerForm(this);
            addWorkerForm.MdiParent = this.MdiParent;
            addWorkerForm.Show();
        }
        public void updateWorkersData(){
            con.Open();
            string query = @"SELECT workers.workerId, workers.name, workers.surname, workers.dateOfBirth, workers.email, 
                            positions.positionName, positions.salary
                            FROM workers LEFT JOIN positions ON workers.positionId = positions.positionId";
            MySqlDataAdapter adap = new MySqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            con.Close();
            this.workersDataGridView.DataSource = ds.Tables[0].DefaultView;
            foreach (DataGridViewColumn column in workersDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            this.workersDataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic;
            setCellsNames();
            con.Close();
            workersDataGridView.Sort(workersDataGridView.Columns[0], ListSortDirection.Ascending);
        }
        private void btnDeleteWorker_Click(object sender, EventArgs e)
        {
            if (selectedIndex != "")
            {
                try
                {
                    string query = "delete from myDB.workers where workerId='" + selectedIndex + "';";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    updateWorkersData();
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
        private void setCellsNames()
        {
            this.workersDataGridView.Columns["workerId"].HeaderText = "Id";
            this.workersDataGridView.Columns["name"].HeaderText = "Name";
            this.workersDataGridView.Columns["surname"].HeaderText = "Surname";
            this.workersDataGridView.Columns["dateOfBirth"].HeaderText = "Date of birth";
            this.workersDataGridView.Columns["email"].HeaderText = "Email";
            this.workersDataGridView.Columns["positionName"].HeaderText = "Position";
            this.workersDataGridView.Columns["salary"].HeaderText = "Salary";
        }
        private List<string> getListOfCellsNames()
        {
            List<string> names = new List<string>();
            names.Add("Id");
            names.Add("Name");
            names.Add("Surname");
            names.Add("Date of birth");
            names.Add("Email");
            names.Add("Position");
            names.Add("Salary");
            return names;
        }
        private List<string> getListOfPositions()
        {
            List<string> positions;
            DataTable dt = numberOfPositions();
            positions = new List<string>(dt.Rows.Count);
            foreach (DataRow row in dt.Rows)
                positions.Add((string)row["positionName"]);
            return positions;
        }
        private void workersDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedIndex = workersDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnUpdateWorker_Click(object sender, EventArgs e)
        {
            updateWorkerForm = new UpdateWorkerForm(this,workersDataGridView.ColumnCount, 
                workersDataGridView.Rows[workersDataGridView.SelectedCells[0].RowIndex], 
                getListOfCellsNames(), getListOfPositions());
            updateWorkerForm.MdiParent = this.MdiParent;
            updateWorkerForm.Show();
        }

        private void workersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedIndex = workersDataGridView.SelectedRows.Count.ToString();
        }

        private void btnAverageSalary_Click(object sender, EventArgs e)
        {
            int averageSalary = 0;
            for(int i = 0; i < workersDataGridView.RowCount; i++){
                averageSalary += Int32.Parse(workersDataGridView.Rows[i].Cells[workersDataGridView.ColumnCount - 1].Value.ToString());
            }
            averageSalary /= workersDataGridView.RowCount;
            MessageBox.Show("Average salary is "+ averageSalary.ToString());
        }

        private void btnShowPositions_Click(object sender, EventArgs e)
        {
            positionsForm = new PositionsForm(this);
            positionsForm.MdiParent = this.MdiParent;
            positionsForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                try
                {
                    con.Open();
                    string query = @"SELECT workers.workerId, workers.name, workers.surname, workers.dateOfBirth, workers.email, 
                                positions.positionName, positions.salary
                                FROM workers LEFT JOIN positions ON workers.positionId = positions.positionId where workers.name=@search";
                    MySqlDataAdapter adap = new MySqlDataAdapter(query, con);
                    adap.SelectCommand.Parameters.Add(new MySqlParameter
                    {
                        ParameterName = "@search",
                        Value = textBoxSearch.Text
                    });
                    DataSet ds = new DataSet();
                    adap.Fill(ds);
                    con.Close();
                    this.workersDataGridView.DataSource = ds.Tables[0].DefaultView;
                    foreach (DataGridViewColumn column in workersDataGridView.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.Automatic;
                    }
                    this.workersDataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic;
                    setCellsNames();
                    con.Close();
                    workersDataGridView.Sort(workersDataGridView.Columns[0], ListSortDirection.Ascending);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }
            else
                MessageBox.Show("You have to enter your search query.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateWorkersData();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
