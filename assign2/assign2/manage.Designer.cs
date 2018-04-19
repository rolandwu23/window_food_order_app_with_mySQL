namespace assign2
{
    partial class manage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.usermanage1 = new assign2.usermanage();
            this.foodmanage1 = new assign2.foodmanage();
            this.ordermanage1 = new assign2.ordermanage();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.Tomato;
            this.btnUser.Location = new System.Drawing.Point(24, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(113, 48);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.btnFood);
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 502);
            this.panel1.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Maroon;
            this.sidePanel.Location = new System.Drawing.Point(3, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(15, 48);
            this.sidePanel.TabIndex = 2;
            // 
            // btnFood
            // 
            this.btnFood.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.Color.Tomato;
            this.btnFood.Location = new System.Drawing.Point(24, 54);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(113, 48);
            this.btnFood.TabIndex = 3;
            this.btnFood.Text = "Food";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Tomato;
            this.btnOrder.Location = new System.Drawing.Point(24, 108);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(113, 48);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Tomato;
            this.btnLogOut.Location = new System.Drawing.Point(24, 162);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(113, 48);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // usermanage1
            // 
            this.usermanage1.BackColor = System.Drawing.Color.Tan;
            this.usermanage1.Location = new System.Drawing.Point(144, 1);
            this.usermanage1.Name = "usermanage1";
            this.usermanage1.Size = new System.Drawing.Size(565, 502);
            this.usermanage1.TabIndex = 1;
            // 
            // foodmanage1
            // 
            this.foodmanage1.BackColor = System.Drawing.Color.Tan;
            this.foodmanage1.Location = new System.Drawing.Point(144, 1);
            this.foodmanage1.Name = "foodmanage1";
            this.foodmanage1.Size = new System.Drawing.Size(565, 502);
            this.foodmanage1.TabIndex = 2;
            // 
            // ordermanage1
            // 
            this.ordermanage1.BackColor = System.Drawing.Color.Tan;
            this.ordermanage1.Location = new System.Drawing.Point(144, 1);
            this.ordermanage1.Name = "ordermanage1";
            this.ordermanage1.Size = new System.Drawing.Size(565, 502);
            this.ordermanage1.TabIndex = 3;
            // 
            // manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 504);
            this.Controls.Add(this.ordermanage1);
            this.Controls.Add(this.foodmanage1);
            this.Controls.Add(this.usermanage1);
            this.Controls.Add(this.panel1);
            this.Name = "manage";
            this.Text = "manage";
            this.Load += new System.EventHandler(this.manage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnLogOut;
        private usermanage usermanage1;
        private foodmanage foodmanage1;
        private ordermanage ordermanage1;
    }
}