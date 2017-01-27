using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void workersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mydbDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydbDataSet.animals' table. You can move, or remove it, as needed.
            this.animalsTableAdapter.Fill(this.mydbDataSet.animals);
            // TODO: This line of code loads data into the 'mydbDataSet.workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.mydbDataSet.workers);
            this.workersDataGridView.Sort(workersDataGridView.Columns[0], ListSortDirection.Ascending);
        }
    }
}
