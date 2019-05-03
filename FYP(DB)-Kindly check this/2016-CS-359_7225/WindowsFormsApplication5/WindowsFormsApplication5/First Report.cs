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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsFormsApplication5
{
    public partial class First_Report : Form
    {
        public First_Report()
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
                    comboBoxProjects.Items.Add(SNAME);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void First_Report_Load(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(conURL);
            //conn.Open();
            //string p = "select Project.Title from Project where Project.Title = '"+comboBoxProjects.Text+"'";
            //SqlCommand command = new SqlCommand(p, conn);
            //command.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(command);
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Test.pdf", FileMode.Create));
            doc.Open();

            //string p = "select Project.Title  from Project where Project.Title = '" + comboBoxProjects.Text + "'";
            //SqlCommand command = new SqlCommand(p, conn);
            //command.ExecuteNonQuery();



            Paragraph paragraph = new Paragraph("This is my first pdf file");
            doc.Add(paragraph);
            doc.Close();
            MessageBox.Show("report generated in documents");
            //var doc1 = new iTextSharp.text.Document();
            //string path = Server.MapPath("PDF_Files");
            //PdfWriter.GetInstance(doc1, new FileStream(path + "/Doc1.pdf", FileMode.Create));
            //doc1.Open();
            //doc1.Add(new Paragraph("My sample text goes here."));
            //doc1.Close();

            //SqlConnection conn = new SqlConnection(conURL);
            //conn.Open();
            //string p = "select Project.Title , GroupProject.GroupId from Project where Project.Title = '" + comboBoxProjects.Text + "' join GroupProject on GroupProject.ProjectId = Project.Id ";
            //SqlCommand command = new SqlCommand(p, conn);
            //command.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(command);
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Main_Window a = new Main_Window();
            this.Hide();
            a.Show();
        }
    }
}
