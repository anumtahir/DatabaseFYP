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
    public partial class Student_Group : Form
    {
        public Student_Group()
        {
            InitializeComponent();
        }

        String conURL = "Data Source=HAIER-PC\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";

       



        private void cmdCreated_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    //string check = @"(select count(*) from Project where Title='" + txtTitle.Text + "')";
                    string p1 = "insert into [Group] (Created_On) values (@DATETIME)";

                    SqlCommand command = new SqlCommand(p1, conn);
                    command.Parameters.Add("@DATETIME", SqlDbType.Date).Value = dateTimePickerCO.Value.Date;
                    command.ExecuteNonQuery();
                   

                    foreach (DataGridViewRow row in dataGridView1.Rows )
                    {
                        
                        bool isselected = Convert.ToBoolean(row.Cells["Check"].Value);
                        if (isselected)
                        {
                            using (SqlCommand cmd = new SqlCommand("insert into GroupStudent(GroupId,StudentId,Status,AssignmentDate) values((select  Id from [Group] where Created_On=(select distinct Created_On from [Group] where Created_On='" + dateTimePickerCO.Value.Date + "')),@StudentId,(select Id from Lookup where Value='" + comboBox1.Text + "'),@DATE)",conn))
                            {
                                cmd.Parameters.Add("@DATE", SqlDbType.Date).Value = dateTimePickerAD.Value.Date;

                                cmd.Parameters.AddWithValue("@StudentId", row.Cells[4].Value);
                                
                                cmd.ExecuteNonQuery();
                               
                                    
                            }
                        }
                       
                    }

                    

                    MessageBox.Show("Assigned Successfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Student_Group_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            string p = "select Person.FirstName,Person.LastName,Student.RegistrationNo,Student.Id from Person join Student on Person.Id=Student.Id";
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
