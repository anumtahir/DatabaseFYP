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
    public partial class Manage_Evaluation : Form
    {
        public Manage_Evaluation()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        String conURL = "Data Source=HAIER-PC\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter Name field. ");
            }
            else
            {


                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    try
                    {

                        string check = @"(select count(*) from Evaluation where Name='" + txtName.Text + "')";
                        string p = "insert into Evaluation (Name , TotalMarks , TotalWeightage) values ('" + txtName.Text + "' , '" +txtTotalMarks.Text + "' , '"+txtTW.Text+"');";
                        SqlCommand command = new SqlCommand(p, conn);

                        SqlCommand cmda = new SqlCommand(check, conn);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Evaluation already exists");
                        }
                        else
                        {
                            command.ExecuteNonQuery();

                            MessageBox.Show("Added Evaluation successfully");
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



        public void disp_data()
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            string p = "select * from Evaluation";
            SqlCommand command = new SqlCommand(p, conn);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();




        }

        private void Manage_Evaluation_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" )
            {
                MessageBox.Show("Must enter Name fields. ");
            }
            else
            {


                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    string q = "select Id from Evaluation where Name ='" + txtName.Text + "'   ";
                    if (q != null)
                    {


                        string p = "delete from Evaluation where Name ='" + txtName.Text + "'   ";
                        SqlCommand command = new SqlCommand(p, conn);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Deleted Evaluation successfully");
                        disp_data();
                    }
                    else
                    {
                        MessageBox.Show("This evaluation doesn't exist");
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

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            


                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    string q = "select Id from Evaluation where Name ='" + txtName.Text + "'   ";
                    if (q != null)
                    {


                        string p = "update Evaluation set Name ='" + txtName.Text + "' , TotalMarks ='" + txtTotalMarks.Text + "' , TotalWeightage ='" + txtTW.Text + "' where Name = '"+txtName.Text+"'";

                        SqlCommand command = new SqlCommand(p, conn);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Updated Evaluation successfully");
                        disp_data();
                    }
                    else
                    {
                        MessageBox.Show("This Evaluation doesn't exist");
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

        private void label2_Click_1(object sender, EventArgs e)
        {
            Main_Window a = new Main_Window();
            this.Hide();
            a.Show();
        }
    }
}
