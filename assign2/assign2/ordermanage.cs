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
    public partial class ordermanage : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        public ordermanage()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\Desktop\Assign.accdb;
Persist Security Info=False;";
        }

        private void ordermanage_Load(object sender, EventArgs e)
        {
            this.orderTableAdapter.Fill(this.assignDataSet.order);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.orderBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.orderBindingSource.MoveNext();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbCategory.Text = "";
            tbPrice.Text = "";
            tbQuantity.Text = "";
            tbTotal.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string a = tbName.Text;
            string b = tbCategory.Text;
            decimal c = decimal.Parse(tbPrice.Text);
            int f = int.Parse(tbQuantity.Text);
            decimal g = decimal.Parse(tbTotal.Text);

            this.Validate();
            this.orderBindingSource.EndEdit();
            this.orderTableAdapter.Insert(a,b,c,f,g);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        

            decimal a = decimal.Parse(tbPrice.Text);
            int b = int.Parse(tbQuantity.Text);
            decimal c = decimal.Parse(tbTotal.Text);

            try
            {
                OleDbCommand command = new OleDbCommand();
                connection.Open();
                command.Connection = connection;
                command.CommandText = "update [order] set [food_name]='"+tbName.Text+ "',[category]='"+tbCategory.Text+ "', [price]='"+a+ "',[quantity]='"+b+ "',[total]='"+c+"'";
                command.ExecuteNonQuery();
                connection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            OleDbCommand command = new OleDbCommand();
            //this.orderTableAdapter.Dispose();
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete * from [order] where [food_name]='"+tbName.Text+"'";
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
