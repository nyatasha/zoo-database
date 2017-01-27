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
    public partial class PositionsForm : Form
    {
        private WorkersForm workersform;

        public PositionsForm(WorkersForm form)
        {
            InitializeComponent();
            this.workersform = form;
        }

        private void PositionsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydbDataSet.positions' table. You can move, or remove it, as needed.
            this.positionsTableAdapter.Fill(this.mydbDataSet.positions);
        }

        private void positionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.positionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mydbDataSet);
        }

        private void PositionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            workersform.updateWorkersData();
        }

        private void btnSavePositions_Click(object sender, EventArgs e)
        {
            workersform.updateWorkersData();
        }
        
        private void btnFilter_Click(object sender, EventArgs e)
        {
            this.positionsBindingSource.Filter = "salary ="+this.textBox1.Text;
            /*this.positionsBindingSource.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@search",
                Value = textBoxSearch.Text
            });*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.positionsTableAdapter.update(positionsDataGridView);
        }

    }
}
