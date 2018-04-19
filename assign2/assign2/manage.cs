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
    public partial class manage : Form
    {
        Thread th;
        public manage()
        {
            InitializeComponent();
        }

        private void manage_Load(object sender, EventArgs e)
        {
            usermanage1.BringToFront();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnUser.Height;
            sidePanel.Top = btnUser.Top;
            usermanage1.BringToFront();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnFood.Height;
            sidePanel.Top = btnFood.Top;
            foodmanage1.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnOrder.Height;
            sidePanel.Top = btnOrder.Top;
            ordermanage1.BringToFront();
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
