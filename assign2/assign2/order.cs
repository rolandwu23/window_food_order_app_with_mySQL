using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assign2
{
    public partial class order : Form
    {
        
        int count = 2;
        public order()
        {
            InitializeComponent();
        }

        private void chicken1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try { 


                if (count == 2)
            {
                chicken1.BringToFront();
                count++;
            }
            else if (count == 3)
            {
                french_fries1.BringToFront();
                count++;
            }
            }
            catch (Exception)
            {
                MessageBox.Show("No more items");
            }
            
        }

        private void order_Load(object sender, EventArgs e)
        {

            beef1.BringToFront();
        }
    }
}
