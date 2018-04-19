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
    public partial class myorderUC : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        public myorderUC()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\Desktop\Assign.accdb;
Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand();
            this.orderTableAdapter.Dispose();
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete * from [order]";
                command.ExecuteNonQuery();
                MessageBox.Show("Orderred Items are cleared");
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void myorderUC_Load(object sender, EventArgs e)
        {
            this.orderTableAdapter.Fill(this.assignDataSet.order);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
