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
    public partial class AddAnimalForm : Form
    {
        private AnimalsForm animalsForm;
        public AddAnimalForm(AnimalsForm form)
        {
            InitializeComponent();
            this.animalsForm = form;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string conString = "Server=127.0.0.1;Database=myDB;Uid=root;Pwd=softkitty1";
                MySqlConnection con = new MySqlConnection(conString);

                string query1 = "SET FOREIGN_KEY_CHECKS=0";
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();

                string query = "insert into myDB.animals(class, species,nickname,gender,age,foodtype,zookeeper) values('" 
                    + this.textClass.Text + "','" + this.textSpecies.Text + "','" + this.textNickname.Text + "','" 
                    + this.textGender.Text + "','" + this.textAge.Text + "','" + this.textFood.Text + "','" + this.textZookeeper.Text+"');";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
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
    }
}
