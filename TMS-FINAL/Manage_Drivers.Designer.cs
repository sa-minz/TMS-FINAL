namespace TMS_FINAL
{
    partial class Manage_Drivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Drivers));
            label1 = new Label();
            lblDriverName = new Label();
            lblLicense = new Label();
            lblContact = new Label();
            lblDOB = new Label();
            lblAddress = new Label();
            txtDriverName = new TextBox();
            txtLicenseNo = new TextBox();
            txtAddress = new TextBox();
            DOB = new DateTimePicker();
            dgvManageDrivers = new DataGridView();
            btnAdd = new Button();
            btnupdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            panel1 = new Panel();
            btnUser = new Button();
            btnLogout = new Button();
            btnVehicles = new Button();
            btnReports = new Button();
            btnDrivers = new Button();
            btnRoutes = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtContact = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvManageDrivers).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Mincho Demibold", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(464, 42);
            label1.Name = "label1";
            label1.Size = new Size(286, 36);
            label1.TabIndex = 0;
            label1.Text = "MANAGE DRIVERS";
            // 
            // lblDriverName
            // 
            lblDriverName.AutoSize = true;
            lblDriverName.Font = new Font("Bahnschrift", 10.2F);
            lblDriverName.Location = new Point(360, 118);
            lblDriverName.Name = "lblDriverName";
            lblDriverName.Size = new Size(55, 21);
            lblDriverName.TabIndex = 1;
            lblDriverName.Text = "Name";
            // 
            // lblLicense
            // 
            lblLicense.AutoSize = true;
            lblLicense.Font = new Font("Bahnschrift", 10.2F);
            lblLicense.Location = new Point(360, 159);
            lblLicense.Name = "lblLicense";
            lblLicense.Size = new Size(139, 21);
            lblLicense.TabIndex = 2;
            lblLicense.Text = "License Number ";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Bahnschrift", 10.2F);
            lblContact.Location = new Point(360, 209);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(134, 21);
            lblContact.TabIndex = 3;
            lblContact.Text = "Contact Number";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Bahnschrift", 10.2F);
            lblDOB.Location = new Point(360, 250);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(108, 21);
            lblDOB.TabIndex = 5;
            lblDOB.Text = "Date Of Birth";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Bahnschrift", 10.2F);
            lblAddress.Location = new Point(360, 305);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(73, 21);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Address";
            // 
            // txtDriverName
            // 
            txtDriverName.Location = new Point(532, 116);
            txtDriverName.Name = "txtDriverName";
            txtDriverName.Size = new Size(176, 27);
            txtDriverName.TabIndex = 7;
            // 
            // txtLicenseNo
            // 
            txtLicenseNo.Location = new Point(532, 157);
            txtLicenseNo.Name = "txtLicenseNo";
            txtLicenseNo.Size = new Size(176, 27);
            txtLicenseNo.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(532, 305);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(176, 27);
            txtAddress.TabIndex = 10;
            // 
            // DOB
            // 
            DOB.Location = new Point(532, 259);
            DOB.Name = "DOB";
            DOB.Size = new Size(176, 27);
            DOB.TabIndex = 11;
            // 
            // dgvManageDrivers
            // 
            dgvManageDrivers.BackgroundColor = Color.White;
            dgvManageDrivers.BorderStyle = BorderStyle.None;
            dgvManageDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManageDrivers.Location = new Point(264, 366);
            dgvManageDrivers.Name = "dgvManageDrivers";
            dgvManageDrivers.RowHeadersWidth = 51;
            dgvManageDrivers.Size = new Size(649, 193);
            dgvManageDrivers.TabIndex = 12;
            dgvManageDrivers.CellClick += dgvManageDrivers_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.RosyBrown;
            btnAdd.Font = new Font("Bahnschrift", 10.2F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(770, 118);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 42);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.IndianRed;
            btnupdate.Font = new Font("Bahnschrift", 10.2F);
            btnupdate.ForeColor = Color.White;
            btnupdate.Location = new Point(770, 171);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(109, 42);
            btnupdate.TabIndex = 14;
            btnupdate.Text = "Update ";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Font = new Font("Bahnschrift", 10.2F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(770, 229);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 42);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Tomato;
            btnClear.Font = new Font("Bahnschrift", 10.2F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(770, 284);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 42);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
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
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 607);
            panel1.TabIndex = 17;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.Honeydew;
            btnUser.Font = new Font("Bahnschrift", 9F);
            btnUser.Location = new Point(40, 32);
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
            btnLogout.Location = new Point(40, 498);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(148, 61);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnVehicles
            // 
            btnVehicles.BackColor = Color.Honeydew;
            btnVehicles.Font = new Font("Bahnschrift", 9F);
            btnVehicles.Location = new Point(40, 123);
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
            btnReports.Location = new Point(40, 411);
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
            btnDrivers.Location = new Point(40, 225);
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
            btnRoutes.Location = new Point(40, 318);
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(360, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(532, 209);
            txtContact.Mask = "+00-000000000";
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(176, 27);
            txtContact.TabIndex = 19;
            // 
            // Manage_Drivers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(925, 600);
            Controls.Add(txtContact);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnupdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvManageDrivers);
            Controls.Add(DOB);
            Controls.Add(txtAddress);
            Controls.Add(txtLicenseNo);
            Controls.Add(txtDriverName);
            Controls.Add(lblAddress);
            Controls.Add(lblDOB);
            Controls.Add(lblContact);
            Controls.Add(lblLicense);
            Controls.Add(lblDriverName);
            Controls.Add(label1);
            Name = "Manage_Drivers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage_Drivers";
            Load += Manage_Drivers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvManageDrivers).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblDriverName;
        private Label lblLicense;
        private Label lblContact;
        private Label lblDOB;
        private Label lblAddress;
        private TextBox txtDriverName;
        private TextBox txtLicenseNo;
        private TextBox txtAddress;
        private DateTimePicker DOB;
        private DataGridView dgvManageDrivers;
        private Button btnAdd;
        private Button btnupdate;
        private Button btnDelete;
        private Button btnClear;
        private Panel panel1;
        private Button btnUser;
        private Button btnLogout;
        private Button btnVehicles;
        private Button btnReports;
        private Button btnDrivers;
        private Button btnRoutes;
        private PictureBox pictureBox1;
        private MaskedTextBox txtContact;
        private PictureBox pictureBox2;
    }
}