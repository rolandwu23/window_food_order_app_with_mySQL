using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace assign2
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        Thread th;
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\Desktop\Assign.accdb;
Persist Security Info=False;";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();


                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from usertable where username='" + tbUsername.Text + "' and password='" + tbPassword.Text + "'";

                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;

                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    if (tbUsername.Text == "admin")
                    {
                        //manage m = new manage();
                        //m.Show();
                        this.Close();
                        th = new Thread(openmanage);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();


                    }
                    else
                    {
                        //account account = new account();
                        //account.Show();
                        this.Close();
                        th = new Thread(openaccount);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();


                    }
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and Password");
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                }
                else if (count <= 0)
                {
                    MessageBox.Show("Incorrect Username and Password");
                    tbUsername.Text = "";
                    tbPassword.Text = "";

                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //register register = new register();
            //register.Show();
            this.Close();
            th = new Thread(openregister);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
        private void openregister(object obj)
        {
            Application.Run(new register());
        }
        private void openmanage(object obj)
        {
            Application.Run(new manage());
        }
        private void openaccount(object obj)
        {
            Application.Run(new account());
        }
    }
}
