namespace assign2
{
    partial class orderUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.beef1 = new assign2.beef();
            this.button1 = new System.Windows.Forms.Button();
            this.chicken1 = new assign2.chicken();
            this.french_fries1 = new assign2.french_fries();
            this.SuspendLayout();
            // 
            // beef1
            // 
            this.beef1.Location = new System.Drawing.Point(0, 0);
            this.beef1.Name = "beef1";
            this.beef1.Size = new System.Drawing.Size(634, 407);
            this.beef1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Elephant", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(52, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chicken1
            // 
            this.chicken1.Location = new System.Drawing.Point(0, 3);
            this.chicken1.Name = "chicken1";
            this.chicken1.Size = new System.Drawing.Size(634, 407);
            this.chicken1.TabIndex = 3;
            // 
            // french_fries1
            // 
            this.french_fries1.Location = new System.Drawing.Point(-1, 0);
            this.french_fries1.Name = "french_fries1";
            this.french_fries1.Size = new System.Drawing.Size(634, 407);
            this.french_fries1.TabIndex = 4;
            // 
            // orderUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.french_fries1);
            this.Controls.Add(this.chicken1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.beef1);
            this.Name = "orderUC";
            this.Size = new System.Drawing.Size(636, 502);
            this.Load += new System.EventHandler(this.orderUC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private beef beef1;
        private System.Windows.Forms.Button button1;
        private chicken chicken1;
        private french_fries french_fries1;
    }
}
