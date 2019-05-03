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
                            disp_data();
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
            //MessageBox.Show("Fill tiltle and description to delete data.");

            if (txtTitle.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Please enter all fields. ");
            }

           
            else
            {


                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    try
                    {


                        string check = @"(select count(*) from Project where Title='" + txtTitle.Text + "' and Description='"+txtDescription.Text+"')";
                        
                        SqlCommand cmda = new SqlCommand(check, conn);
                        int count = (int)cmda.ExecuteScalar();
                        if (count < 0 )
                        {
                            MessageBox.Show("Project doesn't exists");
                        }

                        else
                        {

                            string p = "delete from Project where Description ='" + txtDescription.Text + "' and Title = '"+txtTitle.Text+"'";

                            SqlCommand command = new SqlCommand(p, conn);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Deleted project successfully");
                            disp_data();
                        }
                    
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

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

        public void disp_data()
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            string p = "select * from Project";
            SqlCommand command = new SqlCommand(p, conn);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();




        }



        private void button2_Click(object sender, EventArgs e)
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
                    string q = "select Id from Project where Description ='" + txtDescription.Text + "'   ";
                    if (q != null)
                    {

                        
                        string p = "update Project set Title ='" + txtTitle.Text + "' , Description ='"+txtDescription.Text+"' where Title ='"+txtTitle.Text+"' ";

                        SqlCommand command = new SqlCommand(p, conn);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Updated project successfully");
                        disp_data();
                    }
                    else
                    {
                        MessageBox.Show("This project doesn't exist");
                    }
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
                    MessageBox.Show("Didn't update");
                }
            }
        }

        private void Manage_Projects_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Main_Window a = new Main_Window();
            this.Hide();
            a.Show();
        }
    }
}
