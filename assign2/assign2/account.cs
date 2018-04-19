using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace assign2
{
    public partial class account : Form
    {
        Thread th;
        
        public account()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnMenu.Height;
            sidePanel.Top = btnMenu.Top;
            orderUC1.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnOrder.Height;
            sidePanel.Top = btnOrder.Top;
            placeorderUC1.BringToFront();
        }

        private void account_Load(object sender, EventArgs e)
        {
            orderUC1.BringToFront();
           
        }

        private void btnMyOrder_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           
}

        private void placeorderUC2_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnLogOut.Height;
            sidePanel.Top = btnLogOut.Top;
            
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
