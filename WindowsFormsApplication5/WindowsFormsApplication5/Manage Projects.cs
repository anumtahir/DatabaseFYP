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

namespace WindowsFormsApplication5
{
    public partial class Manage_Projects : Form
    {
        public Manage_Projects()
        {
            InitializeComponent();
        }


        String conURL = "Data Source=HAIER-PC\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";

       
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Please enter Title field. ");
            }
            else
            {


                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    try
                    {

                        string check = @"(select count(*) from Project where Title='" + txtTitle.Text + "')";
                        string p = "insert into Project (Description , Title) values ('" + this.txtDescription.Text.ToString() + "' , '" + this.txtTitle.Text.ToString() + "');";
                        SqlCommand command = new SqlCommand(p, conn);

                        SqlCommand cmda = new SqlCommand(check, conn);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Project already exists");
                        }
                        else
                        {
                            command.ExecuteNonQuery();

                            MessageBox.Show("Added project successfully");
                        }




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Didn't add");
                }



            }

        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {

            if (txtTitle.Text == "" && txtDescription.Text == "")
            {
                MessageBox.Show("Please enter all fields. ");
            }
            else
            {


                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    string p = "delete from Project where Description ='" + this.txtDescription.Text.ToString() + "'   ";
                    SqlCommand command = new SqlCommand(p, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Deleted project successfully");
                    //if (lblTitle.Text != null && lblDescription.Text != null)
                    //{
                    //    MessageBox.Show("Deleted project successfully");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Fill all the fields");
                    //}


                }
                else
                {
                    MessageBox.Show("Didn't delete");
                }
            }
        }
    }
}
