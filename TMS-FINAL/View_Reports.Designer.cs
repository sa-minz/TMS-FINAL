namespace TMS_FINAL
{
    partial class View_Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Reports));
            label1 = new Label();
            panel1 = new Panel();
            btnUser = new Button();
            btnLogout = new Button();
            btnVehicles = new Button();
            btnReports = new Button();
            btnDrivers = new Button();
            btnRoutes = new Button();
            pictureBox2 = new PictureBox();
            lblReportType = new Label();
            cmbReportType = new ComboBox();
            btnFilter = new Button();
            dgvViewReports = new DataGridView();
            btnPrint = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvViewReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Mincho Demibold", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(426, 42);
            label1.Name = "label1";
            label1.Size = new Size(295, 36);
            label1.TabIndex = 0;
            label1.Text = "MANAGE REPORTS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnVehicles);
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(btnDrivers);
            panel1.Controls.Add(btnRoutes);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 607);
            panel1.TabIndex = 7;
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Bahnschrift", 9F);
            btnUser.Location = new Point(40, 32);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(148, 61);
            btnUser.TabIndex = 0;
            btnUser.Text = "MANAGE USER";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Bahnschrift", 9F);
            btnLogout.Location = new Point(40, 505);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(148, 61);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnVehicles
            // 
            btnVehicles.Font = new Font("Bahnschrift", 9F);
            btnVehicles.Location = new Point(40, 126);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new Size(148, 61);
            btnVehicles.TabIndex = 1;
            btnVehicles.Text = "MANAGE VEHICLE";
            btnVehicles.UseVisualStyleBackColor = true;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Bahnschrift", 9F);
            btnReports.Location = new Point(40, 407);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(148, 61);
            btnReports.TabIndex = 4;
            btnReports.Text = "MANAGE REPORTS";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnDrivers
            // 
            btnDrivers.Font = new Font("Bahnschrift", 9F);
            btnDrivers.Location = new Point(40, 222);
            btnDrivers.Name = "btnDrivers";
            btnDrivers.Size = new Size(148, 61);
            btnDrivers.TabIndex = 2;
            btnDrivers.Text = "MANAGE DRIVER";
            btnDrivers.UseVisualStyleBackColor = true;
            btnDrivers.Click += btnDrivers_Click;
            // 
            // btnRoutes
            // 
            btnRoutes.Font = new Font("Bahnschrift", 9F);
            btnRoutes.Location = new Point(40, 309);
            btnRoutes.Name = "btnRoutes";
            btnRoutes.Size = new Size(148, 61);
            btnRoutes.TabIndex = 3;
            btnRoutes.Text = "MANAGE ROUTE";
            btnRoutes.UseVisualStyleBackColor = true;
            btnRoutes.Click += btnRoutes_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 607);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // lblReportType
            // 
            lblReportType.AutoSize = true;
            lblReportType.Font = new Font("Bahnschrift", 10.2F);
            lblReportType.Location = new Point(359, 127);
            lblReportType.Name = "lblReportType";
            lblReportType.Size = new Size(99, 21);
            lblReportType.TabIndex = 1;
            lblReportType.Text = "Report Type";
            // 
            // cmbReportType
            // 
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Items.AddRange(new object[] { "Users", "Vehicles", "Drivers", "Routes" });
            cmbReportType.Location = new Point(527, 125);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(176, 28);
            cmbReportType.TabIndex = 0;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.RosyBrown;
            btnFilter.Font = new Font("Bahnschrift", 10.2F);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(759, 120);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(109, 42);
            btnFilter.TabIndex = 6;
            btnFilter.Text = "Load";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnLoadReport_Click;
            // 
            // dgvViewReports
            // 
            dgvViewReports.BackgroundColor = Color.White;
            dgvViewReports.BorderStyle = BorderStyle.None;
            dgvViewReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewReports.Location = new Point(271, 197);
            dgvViewReports.Name = "dgvViewReports";
            dgvViewReports.RowHeadersWidth = 51;
            dgvViewReports.Size = new Size(642, 303);
            dgvViewReports.TabIndex = 11;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.IndianRed;
            btnPrint.Font = new Font("Bahnschrift", 10.2F);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(759, 506);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(109, 42);
            btnPrint.TabIndex = 10;
            btnPrint.Text = "Export";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnExportExcel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(349, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // View_Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(925, 600);
            Controls.Add(pictureBox1);
            Controls.Add(btnPrint);
            Controls.Add(panel1);
            Controls.Add(dgvViewReports);
            Controls.Add(label1);
            Controls.Add(btnFilter);
            Controls.Add(lblReportType);
            Controls.Add(cmbReportType);
            Name = "View_Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_Reports";
            Load += View_Reports_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvViewReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnUser;
        private Button btnLogout;
        private Button btnVehicles;
        private Button btnReports;
        private Button btnDrivers;
        private Button btnRoutes;
        private Label lblReportType;
        private ComboBox cmbReportType;
        private Button btnFilter;
        private DataGridView dgvViewReports;
        private Button btnPrint;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}