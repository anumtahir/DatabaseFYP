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
    public partial class Group_Project : Form
    {
        public Group_Project()
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
                while (myreader.Read())
                {
                    string SNAME = myreader.GetString(myreader.GetOrdinal("Title"));
                    comboBoxProject.Items.Add(SNAME);

                }
            }
            catch (Exception ex)
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
                try
                {
                    string p1 = "insert into GroupProject (ProjectId , GroupId , AssignmentDate) values ((select Id from Project where Title ='"+comboBoxProject.Text+"') , '"+txtGroupId.Text+"' ,@DATETIME)";

                    SqlCommand command = new SqlCommand(p1, conn);
                    command.Parameters.Add("@DATETIME", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Assigned project to the group successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }


        private void Group_Project_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            string p = "select GroupStudent.GroupId,GroupStudent.StudentId,GroupStudent.AssignmentDate from GroupStudent ";
            SqlCommand command = new SqlCommand(p, conn);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Main_Window a = new Main_Window();
            this.Hide();
            a.Show();
        }
    }
}
