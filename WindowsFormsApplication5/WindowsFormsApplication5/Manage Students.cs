﻿using System;
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
    public partial class Manage_Students : Form
    {
        public Manage_Students()
        {
            InitializeComponent();
        }

        String conURL = "Data Source=HAIER-PC\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "" || txtEmail.Text == "" || txtRegistration.Text == "")
            {
                MessageBox.Show("First Name , Email & Registration# field is necessary to add data.");

            }

            else
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    try
                    {

                        

                       // string check = @"(select count(*) from Person where Email='" + txtEmail.Text + "')";
                        string p2 = "insert into Student(Id,RegistrationNo) values ((select Id from Person where FirstName = '" + txtFName.Text + "' and LastName='" + txtLName.Text + "' and Email ='" + txtEmail.Text + "'), '"+txtRegistration.Text.ToString()+"')";
                        SqlCommand command2 = new SqlCommand(p2, conn);

                        //SqlCommand cmda = new SqlCommand(check, conn);
                        //int count = (int)cmda.ExecuteScalar();
                        //if (count > 0)
                        //{
                        //    MessageBox.Show("This student already exist");
                        //}
                        //else
                        //{
                            command2.ExecuteNonQuery();
                            MessageBox.Show("Added successfully");
                        //}



                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }


            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "" || txtEmail.Text == "" || txtRegistration.Text =="")
            {
                MessageBox.Show("Must enter first name , email & Reg# fields to delete. ");
            }
            else
            {
                try
                {


                    SqlConnection conn = new SqlConnection(conURL);
                    conn.Open();

                    if (conn.State == ConnectionState.Open)
                    {


                        string p = "delete from Student where Id =(select Id from Person where FirstName = '" + txtFName.Text + "' and LastName='" + txtLName.Text + "' and Email ='" + txtEmail.Text + "')  ";
                        SqlCommand command = new SqlCommand(p, conn);


                        command.ExecuteNonQuery();
                        MessageBox.Show("Deleted student successfully");

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
    }
}
