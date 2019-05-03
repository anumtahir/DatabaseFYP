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
            //SqlConnection conn = new SqlConnection(conURL);
            //DataTable dt = new DataTable();
            //SqlDataAdapter a = new SqlDataAdapter("select  Person.Id , Person.FirstName , Person.LastName , Person.Contact , Person.Email , Person.DateOfBirth , Person.Gender, Advisor.Designation , Advisor.Salary , Lookup.Value from Person join Advisor on Person.Id = Advisor.Id ", conn);
            //a.Fill(dt);
            //dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        String conURL = "Data Source=HAIER-PC\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    try
                    {

                        //****************                     string p1 = @"(select FirstName,Email from Person where FirstName = '" + txtFirstName.Text + "' and Email ='" + txtEmail.Text + "' )";
                        //     SqlCommand command1 = new SqlCommand(p1, conn);
                        //    command1.ExecuteNonQuery();
                        //if(("select * from Person where FirstName = '" + txtFirstName.Text + "' and LastName='" + txtLastName.Text + "' and Email ='" + txtEmail.Text + "' "));

                        //string check = @"(select count(*) from Advisor where Email='" + txtEmail.Text + "')";


                        string p1 = "insert into Person (FirstName , LastName , Contact, Email,DateOfBirth , Gender) values ('" + txtFirstName.Text + "' , '" + txtLastName.Text + "'  , '" + txtContact.Text + "' , '" + txtEmail.Text + "' ,  '" + dateTimePicker1.Value + "' , (select Id from Lookup where Value = '" + comboBoxGender.Text + "'))";
                        SqlCommand command = new SqlCommand(p1, conn);
                        command.ExecuteNonQuery();
                        
                        
                        string p2 = "insert into Advisor(Id,Designation , Salary) values ((select Id from Person where FirstName = '" + txtFirstName.Text + "' and LastName='" + txtLastName.Text + "' and Email ='" + txtEmail.Text + "'),(select Id from Lookup where Value = '" + comboBoxDesignation.Text + "') , '" + txtSalary.Text + "' )";
                        SqlCommand command2 = new SqlCommand(p2, conn);

                        //SqlCommand cmda = new SqlCommand(check, conn);
                        //int count = (int)cmda.ExecuteScalar();
                        //if (count > 0)
                        //{
                        //    MessageBox.Show("This advisor already exist");
                        //}
                        //else
                        //{
                            
                            command2.ExecuteNonQuery();
                            MessageBox.Show("Added successfully");
                    
                    DataTable dt = new DataTable();
                    SqlDataAdapter a = new SqlDataAdapter("select  Person.Id , Person.FirstName , Person.LastName , Person.Contact , Person.Email , Person.DateOfBirth , Person.Gender, Advisor.Designation , Advisor.Salary , Lookup.Value from Person join Advisor on Person.Id = Advisor.Id join Lookup on  Lookup.Id = Person.Gender and Lookup.Id = Person.Designation", conn);
                    a.Fill(dt);
                    dataGridView1.DataSource = dt;


                    // }



                }

                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                 }


            
        }
        
        
           
           

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtEmail.Text == "")
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
                        //string q = "select Id"

                        //string p2 = "select Id from Advisor where Id =(select Id from Person where FirstName = '" + txtFirstName.Text + "' and LastName='" + txtLastName.Text + "' and Email ='" + txtEmail.Text + "')  ";

                        //string p3 = "delete from Person where Id = "'+p2+'"";
                        string p1 = "delete from Advisor where Id =(select Id from Person where FirstName = '" + txtFirstName.Text + "' and LastName='" + txtLastName.Text + "' and Email ='" + txtEmail.Text + "')  ";
                        
                        SqlCommand command = new SqlCommand(p1, conn);


                        command.ExecuteNonQuery();



                        string p2 = "delete from Person where FirstName = '" + txtFirstName.Text + "' and LastName='" + txtLastName.Text + "' and Email ='" + txtEmail.Text + "'  ";

                        SqlCommand command2 = new SqlCommand(p2, conn);


                        command2.ExecuteNonQuery();
                        MessageBox.Show("Deleted person successfully");

                    }
                    else
                    {
                        MessageBox.Show("Didn't delete");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        
    }

        private void label2_Click(object sender, EventArgs e)
        {
            Main_Window a = new Main_Window();
            this.Hide();
            a.Show();
        }
    }
}
