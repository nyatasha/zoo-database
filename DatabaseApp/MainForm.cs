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
    public partial class MainForm : Form
    {
        private WorkersForm workersForm;
        private AnimalsForm animalsForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnShowWorkers_Click(object sender, EventArgs e)
        {            
            Form1 f = new Form1();
            f.Show();
            workersForm = new WorkersForm();
            workersForm.Show();
        }

        private void btnShowAnimals_Click(object sender, EventArgs e)
        {
            animalsForm = new AnimalsForm();
            animalsForm.MdiParent = this.MdiParent;
            animalsForm.Show();
        }
    }
}
