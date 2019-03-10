using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication5
{
    public partial class Manage_Advisors : Form
    {
        public Manage_Advisors()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Manage_Advisors_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        String conURL = "Data Source=HAIER-PC\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtEmail.Text == "" || comboBoxDesignation.Text == "")
            {
                MessageBox.Show("First Name , Email & Designation field is necessary to add data.");

            }
            else
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    try
                    {
                        
                        string p1 = @"(select FirstName,Email from Person where FirstName = '" + txtFirstName.Text + "' and Email ='" + txtEmail.Text + "' )";
                        SqlCommand command1 = new SqlCommand(p1, conn);
                        command1.ExecuteNonQuery();


                        string p2 = "insert into Advisor(Designation , Salary) values ((select Id from Lookup where Value = '" + comboBoxDesignation.Text + "') , '" + this.txtSalary.Text.ToString() + "' )      ";
                        SqlCommand command2 = new SqlCommand(p2, conn);
                        command2.ExecuteNonQuery();
                        MessageBox.Show("Added successfully");
                    }

                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                 }


            }
        }
            

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
