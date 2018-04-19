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
    public partial class register : Form
    {
        Thread th;
       
        public register()
        {
            InitializeComponent();
            

            this.tbName.Tag = false;
            this.tbUserName.Tag = false;
            this.tbPassword.Tag = false;
            this.tbConfirmPw.Tag = false;
            this.tbAddress.Tag = false;
            this.tbPhNo.Tag = false;



            this.tbName.Validating += (this.txtBoxEmpty_Validating);
            this.tbUserName.Validating += (this.txtBoxEmpty_Validating);
            this.tbPassword.Validating += (this.txtBoxEmpty_Validating);
            this.tbConfirmPw.Validating += (this.confirm_validating);
            this.tbAddress.Validating += (this.txtBoxEmpty_Validating);
            this.tbPhNo.Validating += (this.txtBoxEmpty_Validating);
            this.tbPhNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPh_keypress);

        }
        public void txtBoxEmpty_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else
            {
                tb.Tag = true;
                tb.BackColor = System.Drawing.SystemColors.Window;
            }
            ValidateAll();
        }

        private void confirm_validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.CompareTo(tbPassword.Text) == 0 || tb.Text.Length == 0)
            {

                tb.Tag = true;
                tb.BackColor = System.Drawing.SystemColors.Window;

            }
            else
            {

                tb.Tag = false;
                tb.BackColor = Color.Red;

            }

            ValidateAll();

        }

        private void tbPh_keypress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


        private void ValidateAll()
        {

            if ((bool)(this.tbName.Tag) &&
            (bool)(this.tbUserName.Tag) &&
            (bool)(this.tbPassword.Tag) &&
            (bool)(this.tbConfirmPw.Tag) &&
            (bool)(this.tbAddress.Tag) &&
            (bool)(this.tbPhNo.Tag))
            {
                this.btnRegister.Enabled = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\Desktop\Assign.accdb;
Persist Security Info=False;";
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "insert into usertable values('" + tbUserName.Text + "','" + tbPassword.Text + "','" + tbName.Text + "','" + tbAddress.Text + "','" + tbPhNo.Text + "')";
                command.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Inserted successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openform1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();


        }
        private void openform1(object obj)
        {
            Application.Run(new Form1());
        }

    }
}
