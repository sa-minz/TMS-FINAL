namespace TMS_FINAL
{
    partial class Manage_Routes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Routes));
            lblManageRoutes = new Label();
            lblStart = new Label();
            lblEnd = new Label();
            lblDistance = new Label();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            txtDistance = new TextBox();
            dgvManageRoutes = new DataGridView();
            lblDate = new Label();
            Date = new DateTimePicker();
            panel1 = new Panel();
            btnUser = new Button();
            btnLogout = new Button();
            btnVehicles = new Button();
            btnReports = new Button();
            btnDrivers = new Button();
            btnRoutes = new Button();
            pictureBox2 = new PictureBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvManageRoutes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblManageRoutes
            // 
            lblManageRoutes.AutoSize = true;
            lblManageRoutes.Font = new Font("Yu Mincho Demibold", 16.2F, FontStyle.Bold);
            lblManageRoutes.ForeColor = Color.MidnightBlue;
            lblManageRoutes.Location = new Point(451, 38);
            lblManageRoutes.Name = "lblManageRoutes";
            lblManageRoutes.Size = new Size(279, 36);
            lblManageRoutes.TabIndex = 0;
            lblManageRoutes.Text = "MANAGE ROUTES";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Bahnschrift", 10.2F);
            lblStart.Location = new Point(352, 113);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(117, 21);
            lblStart.TabIndex = 1;
            lblStart.Text = "Start Location";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Font = new Font("Bahnschrift", 10.2F);
            lblEnd.Location = new Point(352, 164);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(107, 21);
            lblEnd.TabIndex = 2;
            lblEnd.Text = "End Location";
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Font = new Font("Bahnschrift", 10.2F);
            lblDistance.Location = new Point(352, 219);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(116, 21);
            lblDistance.TabIndex = 3;
            lblDistance.Text = "Distance (KM)";
            // 
            // txtStart
            // 
            txtStart.Location = new Point(516, 111);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(176, 27);
            txtStart.TabIndex = 4;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(516, 158);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(176, 27);
            txtEnd.TabIndex = 5;
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(516, 213);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(176, 27);
            txtDistance.TabIndex = 6;
            // 
            // dgvManageRoutes
            // 
            dgvManageRoutes.BackgroundColor = Color.White;
            dgvManageRoutes.BorderStyle = BorderStyle.None;
            dgvManageRoutes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManageRoutes.Location = new Point(315, 345);
            dgvManageRoutes.Name = "dgvManageRoutes";
            dgvManageRoutes.RowHeadersWidth = 51;
            dgvManageRoutes.Size = new Size(559, 221);
            dgvManageRoutes.TabIndex = 7;
            dgvManageRoutes.CellContentClick += dgvRoutes_CellClick;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Bahnschrift", 10.2F);
            lblDate.Location = new Point(352, 273);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(45, 21);
            lblDate.TabIndex = 8;
            lblDate.Text = "Date";
            // 
            // Date
            // 
            Date.Location = new Point(516, 267);
            Date.Name = "Date";
            Date.Size = new Size(176, 27);
            Date.TabIndex = 9;
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
            panel1.TabIndex = 18;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.Honeydew;
            btnUser.Font = new Font("Bahnschrift", 9F);
            btnUser.Location = new Point(53, 26);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(148, 61);
            btnUser.TabIndex = 0;
            btnUser.Text = "MANAGE USERS";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Honeydew;
            btnLogout.Font = new Font("Bahnschrift", 9F);
            btnLogout.Location = new Point(53, 504);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(148, 61);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnVehicles
            // 
            btnVehicles.BackColor = Color.Honeydew;
            btnVehicles.Font = new Font("Bahnschrift", 9F);
            btnVehicles.Location = new Point(53, 123);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new Size(148, 61);
            btnVehicles.TabIndex = 1;
            btnVehicles.Text = "MANAGE VEHICLE";
            btnVehicles.UseVisualStyleBackColor = false;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Honeydew;
            btnReports.Font = new Font("Bahnschrift", 9F);
            btnReports.Location = new Point(53, 418);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(148, 61);
            btnReports.TabIndex = 4;
            btnReports.Text = "MANAGE REPORTS";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnDrivers
            // 
            btnDrivers.BackColor = Color.Honeydew;
            btnDrivers.Font = new Font("Bahnschrift", 9F);
            btnDrivers.Location = new Point(53, 212);
            btnDrivers.Name = "btnDrivers";
            btnDrivers.Size = new Size(148, 61);
            btnDrivers.TabIndex = 2;
            btnDrivers.Text = "MANAGE DRIVERS";
            btnDrivers.UseVisualStyleBackColor = false;
            btnDrivers.Click += btnDrivers_Click;
            // 
            // btnRoutes
            // 
            btnRoutes.BackColor = Color.Honeydew;
            btnRoutes.Font = new Font("Bahnschrift", 9F);
            btnRoutes.Location = new Point(53, 316);
            btnRoutes.Name = "btnRoutes";
            btnRoutes.Size = new Size(148, 61);
            btnRoutes.TabIndex = 3;
            btnRoutes.Text = "MANAGE ROUTES";
            btnRoutes.UseVisualStyleBackColor = false;
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
            // btnAdd
            // 
            btnAdd.BackColor = Color.RosyBrown;
            btnAdd.Font = new Font("Bahnschrift", 10.2F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(778, 92);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 42);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.IndianRed;
            btnUpdate.Font = new Font("Bahnschrift", 10.2F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(778, 143);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 42);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Font = new Font("Bahnschrift", 10.2F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(778, 198);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 42);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Tomato;
            btnClear.Font = new Font("Bahnschrift", 10.2F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(778, 252);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 42);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(351, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // Manage_Routes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(925, 600);
            Controls.Add(pictureBox1);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            Controls.Add(Date);
            Controls.Add(lblDate);
            Controls.Add(dgvManageRoutes);
            Controls.Add(txtDistance);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Controls.Add(lblDistance);
            Controls.Add(lblEnd);
            Controls.Add(lblStart);
            Controls.Add(lblManageRoutes);
            Name = "Manage_Routes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage_Routes";
            Load += Manage_Routes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvManageRoutes).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblManageRoutes;
        private Label lblStart;
        private Label lblEnd;
        private Label lblDistance;
        private TextBox txtStart;
        private TextBox txtEnd;
        private TextBox txtDistance;
        private DataGridView dgvManageRoutes;
        private Label lblDate;
        private DateTimePicker Date;
        private Panel panel1;
        private Button btnUser;
        private Button btnLogout;
        private Button btnVehicles;
        private Button btnReports;
        private Button btnDrivers;
        private Button btnRoutes;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}