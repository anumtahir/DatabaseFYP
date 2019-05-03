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
    public partial class GroupEvaluation : Form
    {
        public GroupEvaluation()
        {
            InitializeComponent();
            FillCombo();
        }


        String conURL = "Data Source=HAIER-PC\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";

        void FillCombo()
        {

            //conn.Open();
            string q = "select * from Evaluation";
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
                    string SNAME = myreader.GetString(myreader.GetOrdinal("Name"));
                    comboBox1.Items.Add(SNAME);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdDoneEvaluation_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                try
                {
                                                                                                                           
                    string p1 = "insert into GroupEvaluation (GroupId , EvaluationId , ObtainedMarks , EvaluationDate) values ('" + txtGroupId.Text + "' , (select Id from Evaluation where Name = '" + comboBox1.Text + "') ,'"+txtObtainedMarks.Text+"',@DATETIME)";

                    SqlCommand command = new SqlCommand(p1, conn);
                    command.Parameters.Add("@DATETIME", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Done group evaluation successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void GroupEvaluation_Load(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {
            Main_Window a = new Main_Window();
            this.Hide();
            a.Show();
        }
    }
}
