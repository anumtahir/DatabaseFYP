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
            Person a = new Person();
            this.Hide();
            a.Show();
        }
    }
}
