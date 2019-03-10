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
    public partial class Person : Form
    {
        public Person()
        {
            InitializeComponent();
        }


        String conURL = "Data Source=HAIER-PC\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("First Name & Email field is necessary to add data.");

            }
            else
            {


                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    try
                    {

                        string check = @"(select count(*) from Person where Email='" + txtEmail.Text + "')";
                        string p1 = "insert into Person (FirstName , LastName , Contact, Email,DateOfBirth , Gender) values ('" + this.txtFName.Text.ToString() + "' , '" + this.txtLName.Text.ToString() + "'  , '" + this.txtContact.Text.ToString() + "' , '" + this.txtEmail.Text.ToString() + "' ,  '" + this.dateTimePickerDOB.Value.ToString() + "' , (select Id from Lookup where Value = '" + comboBoxGender.Text + "'))";

                        SqlCommand command = new SqlCommand(p1, conn);

                        SqlCommand cmda = new SqlCommand(check, conn);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("This user already exist");
                        }
                        else
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Added successfully");
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Didn't Add");
                }
            }
        }

        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Must enter first name & email fields to delete. ");
            }
            

            else
            {
                try
                {


                    SqlConnection conn = new SqlConnection(conURL);
                    conn.Open();

                    if (conn.State == ConnectionState.Open)
                    {
                        
                        
                            string p = "delete from Person where FirstName ='" + this.txtFName.Text.ToString() + "' and Email ='" + txtEmail.Text.ToString() + "'  ";
                            SqlCommand command = new SqlCommand(p, conn);


                            command.ExecuteNonQuery();
                            MessageBox.Show("Deleted person successfully");
                        
                    }
                    else
                    {
                        MessageBox.Show("Didn't delete");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
