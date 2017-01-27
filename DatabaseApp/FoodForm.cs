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
    public partial class FoodForm : Form
    {
        private AnimalsForm animalsForm;
        public FoodForm(AnimalsForm form)
        {
            InitializeComponent();
            this.animalsForm = form;
        }

        private void foodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.foodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mydbDataSet);

        }

        private void FoodForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydbDataSet.food' table. You can move, or remove it, as needed.
            this.foodTableAdapter.Fill(this.mydbDataSet.food);

        }

        private void btnSaveFoodChanges_Click(object sender, EventArgs e)
        {
            animalsForm.updateAnimalsData();
        }
    }
}
