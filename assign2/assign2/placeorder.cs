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

namespace assign2
{
    public partial class placeorder : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public placeorder()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lenovo\Desktop\Assign.accdb;
Persist Security Info=False;";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void placeorder_Load(object sender, EventArgs e)
        {
            
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select food_name from food";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["food_name"].ToString());
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from food where [food_name]='" + comboBox1.Text + "'";
            try
            {
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tbName.Text = (string)reader["food_name"];
                    tbCategory.Text = (string)reader["category"];
                    tbAvailability.Text = (string)reader["Availability"];
                  
                    decimal c = (decimal)reader["Price"];
                    tbPrice.Text = c.ToString("C");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            connection.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(tbQuantity.Text);

            string a = tbPrice.Text.ToString();
            double price = double.Parse(tbPrice.Text, System.Globalization.NumberStyles.Currency);
            double total = qty * price;
            tbTotal.Text = total.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                decimal a = decimal.Parse(tbPrice.Text, System.Globalization.NumberStyles.Currency);
                decimal b = decimal.Parse(tbTotal.Text, System.Globalization.NumberStyles.Currency);
                int c = int.Parse(tbQuantity.Text);

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into [order] ([food_name],[category],[price],[quantity],[total]) values('" + tbName.Text +"','"+tbCategory.Text+"','"+a+"','"+c+"','"+b+"')";
                command.ExecuteNonQuery();
                MessageBox.Show("Item Added!!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
