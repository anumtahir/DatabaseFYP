using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Projects a = new Manage_Projects();
            this.Hide();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_Advisors a = new Manage_Advisors();
            this.Hide();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Person a = new Person();
            //this.Hide();
            //a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manage_Students a = new Manage_Students();
            this.Hide();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Manage_Evaluation a = new Manage_Evaluation();
            this.Hide();
            a.Show();


                 
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Assign_Advisor a = new Assign_Advisor();
            this.Hide();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Student_Group a = new Student_Group();
            this.Hide();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Group_Project a = new Group_Project();
            this.Hide();
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GroupEvaluation a = new GroupEvaluation();
            this.Hide();
            a.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            First_Report a = new First_Report();
            this.Hide();
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }
    }
}
