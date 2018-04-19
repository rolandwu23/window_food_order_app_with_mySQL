using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assign2
{
    public partial class orderUC : UserControl
    {
        int count = 2;
        public orderUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            


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

        private void orderUC_Load(object sender, EventArgs e)
        {
            beef1.BringToFront();
        }
    }
}
