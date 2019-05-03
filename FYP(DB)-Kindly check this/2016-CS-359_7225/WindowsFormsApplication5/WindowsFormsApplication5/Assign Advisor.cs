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
    public partial class Assign_Advisor : Form
    {
        public Assign_Advisor()
        {
            InitializeComponent();
            FillCombo();
        }
        String conURL = "Data Source=HAIER-PC\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";
        void FillCombo()
        {
           
            //conn.Open();
            string q = "select * from Project";
            SqlConnection conn = new SqlConnection(conURL);
            SqlCommand command = new SqlCommand(q, conn);
            //command.ExecuteNonQuery();
            SqlDataReader myreader;
            try
            {
                conn.Open();
                myreader = command.ExecuteReader();
                while(myreader.Read())
                {
                   string SNAME = myreader.GetString(myreader.GetOrdinal("Title"));
                    comboBox2.Items.Add(SNAME);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }




       
        private void cmdAssign_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                //try
                //{
                    //string check = @"(select count(*) from Project where Title='" + txtTitle.Text + "')";
                    string p = "insert into ProjectAdvisor (AdvisorId , ProjectId, AdvisorRole , AssignmentDate) values ('" + txtADName.Text + "' ,  (Select Id from Project where Title='"+comboBox2.Text + "') , (Select Id from Lookup where Value='" + comboBox1.Text + "') ,@DATETIME)";

                SqlCommand command = new SqlCommand(p, conn);
                command.Parameters.Add("@DATETIME", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                command.ExecuteNonQuery();
                MessageBox.Show("Asigned Successfully");

                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }

            conn.Close();
        }

        private void Assign_Advisor_Load(object sender, EventArgs e)
        {
       
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            string p = "select Person.FirstName,Person.LastName,Advisor.Designation,Advisor.Id from Person join Advisor on Person.Id=Advisor.Id";
            SqlCommand command = new SqlCommand(p, conn);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();




        

    }

        private void label2_Click(object sender, EventArgs e)
        {
            Main_Window a = new Main_Window();
            this.Hide();
            a.Show();
        }
    }
}
