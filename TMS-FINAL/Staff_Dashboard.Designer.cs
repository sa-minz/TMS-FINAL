namespace TMS_FINAL
{
    partial class Staff_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Dashboard));
            btnAssign = new Button();
            btnBilling = new Button();
            btnView = new Button();
            btnLogout = new Button();
            panel1 = new Panel();
            btnAssignDriver = new Button();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            label7 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAssign
            // 
            btnAssign.BackColor = Color.DarkSlateGray;
            btnAssign.Font = new Font("Bahnschrift", 9F);
            btnAssign.ForeColor = Color.White;
            btnAssign.Location = new Point(43, 68);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(148, 61);
            btnAssign.TabIndex = 0;
            btnAssign.Text = "ASSIGN VEHICLES";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += btnAssign_Click;
            // 
            // btnBilling
            // 
            btnBilling.BackColor = Color.DarkSlateGray;
            btnBilling.Font = new Font("Bahnschrift", 9F);
            btnBilling.ForeColor = Color.White;
            btnBilling.Location = new Point(43, 266);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(148, 61);
            btnBilling.TabIndex = 2;
            btnBilling.Text = "GENERATE BILLS";
            btnBilling.UseVisualStyleBackColor = false;
            btnBilling.Click += btnBilling_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.DarkSlateGray;
            btnView.Font = new Font("Bahnschrift", 9F);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(43, 363);
            btnView.Name = "btnView";
            btnView.Size = new Size(148, 61);
            btnView.TabIndex = 3;
            btnView.Text = "VIEW RECORDS";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkSlateGray;
            btnLogout.Font = new Font("Bahnschrift", 9F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(43, 469);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(148, 61);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(btnAssignDriver);
            panel1.Controls.Add(btnAssign);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnView);
            panel1.Controls.Add(btnBilling);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 607);
            panel1.TabIndex = 5;
            // 
            // btnAssignDriver
            // 
            btnAssignDriver.BackColor = Color.DarkSlateGray;
            btnAssignDriver.Font = new Font("Bahnschrift", 9F);
            btnAssignDriver.ForeColor = Color.White;
            btnAssignDriver.Location = new Point(43, 171);
            btnAssignDriver.Name = "btnAssignDriver";
            btnAssignDriver.Size = new Size(148, 61);
            btnAssignDriver.TabIndex = 5;
            btnAssignDriver.Text = "ASSIGN DRIVERS";
            btnAssignDriver.UseVisualStyleBackColor = false;
            btnAssignDriver.Click += btnAssignDriver_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(247, 607);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(831, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Mincho Demibold", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(590, 32);
            label1.Name = "label1";
            label1.Size = new Size(208, 36);
            label1.TabIndex = 7;
            label1.Text = "Welcome Staff!";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(310, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label3.Location = new Point(107, 64);
            label3.Name = "label3";
            label3.Size = new Size(22, 23);
            label3.TabIndex = 1;
            label3.Text = "7";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label2.Location = new Point(46, 23);
            label2.Name = "label2";
            label2.Size = new Size(142, 23);
            label2.TabIndex = 0;
            label2.Text = "TOTAL TASKS";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCoral;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(310, 280);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label5.Location = new Point(107, 60);
            label5.Name = "label5";
            label5.Size = new Size(22, 23);
            label5.TabIndex = 1;
            label5.Text = "5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label4.Location = new Point(46, 13);
            label4.Name = "label4";
            label4.Size = new Size(154, 23);
            label4.TabIndex = 0;
            label4.Text = "HOURS LOGGED";
            // 
            // panel5
            // 
            panel5.BackColor = Color.IndianRed;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(310, 453);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 125);
            panel5.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label7.Location = new Point(95, 54);
            label7.Name = "label7";
            label7.Size = new Size(46, 23);
            label7.TabIndex = 1;
            label7.Text = "89%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label6.Location = new Point(18, 16);
            label6.Name = "label6";
            label6.Size = new Size(214, 23);
            label6.TabIndex = 0;
            label6.Text = "EFFICIENCY RATING";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(598, 186);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(305, 368);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // Staff_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(925, 600);
            Controls.Add(pictureBox2);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Staff_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff_Dashboard";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAssign;
        private Button btnBilling;
        private Button btnView;
        private Button btnLogout;
        private Panel panel1;
        private Button btnAssignDriver;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}