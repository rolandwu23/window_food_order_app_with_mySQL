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
    public partial class foodmanage : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        public foodmanage()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\Desktop\Assign.accdb;
Persist Security Info=False;";
        }

        private void tbPhno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.foodBindingSource.MovePrevious();
        }

        private void foodmanage_Load(object sender, EventArgs e)
        {
            this.foodTableAdapter.Fill(this.assignDataSet.food);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.foodBindingSource.MoveNext();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            tbName.Text = "";
            tbDescri.Text = "";
            tbCategory.Text = "";
            tbPrice.Text = "";
            tbAvail.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tbID.Text);
            string b = tbName.Text;
            string c = tbDescri.Text;
            string f = tbCategory.Text;
            decimal g = decimal.Parse(tbPrice.Text);
            string h = tbAvail.Text;

            this.Validate();
            this.foodBindingSource.EndEdit();
            this.foodTableAdapter.Insert(a,b,c,f,g,h);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
       

            this.Validate();
            this.foodBindingSource.EndEdit();
            this.foodTableAdapter.Update(this.assignDataSet.food);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           


         
          try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "delete * from [food] where [food_name] = '" + tbName.Text + "'";
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
