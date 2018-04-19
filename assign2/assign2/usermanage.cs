using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace assign2
{
    public partial class usermanage : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        public usermanage()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\Desktop\Assign.accdb;
Persist Security Info=False;";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.usertableBindingSource.MovePrevious();
        }

        private void usermanage_Load(object sender, EventArgs e)
        {
            this.usertableTableAdapter.Fill(this.assignDataSet.usertable);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.usertableBindingSource.MoveNext();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";
            tbAddress.Text = "";
            tbPhno.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string a = tbName.Text;
            string b = tbUsername.Text;
            string c = tbPassword.Text;
            string f = tbAddress.Text;
            int g = int.Parse(tbPhno.Text);

            this.Validate();
            this.usertableBindingSource.EndEdit();
            this.usertableTableAdapter.Insert(a, b, c, f, g);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usertableBindingSource.EndEdit();
            this.usertableTableAdapter.Update(this.assignDataSet.usertable);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        


            OleDbCommand command = new OleDbCommand();
            //this.orderTableAdapter.Dispose();
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete * from [usertable] where [username]='" + tbUsername.Text + "'";
                command.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }
    }
}
