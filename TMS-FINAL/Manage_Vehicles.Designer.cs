namespace TMS_FINAL
{
    partial class Manage_Vehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Vehicles));
            lblVNo = new Label();
            lblType = new Label();
            lblCap = new Label();
            txtVehicleNo = new TextBox();
            txtCapacity = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvVehicles = new DataGridView();
            cmbVehicleType = new ComboBox();
            lblManageVehicles = new Label();
            panel1 = new Panel();
            btnUser = new Button();
            btnLogout = new Button();
            btnVehicles = new Button();
            btnReports = new Button();
            btnDrivers = new Button();
            btnRoutes = new Button();
            pictureBox2 = new PictureBox();
            btnClear = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblVNo
            // 
            lblVNo.AutoSize = true;
            lblVNo.Font = new Font("Bahnschrift", 10.2F);
            lblVNo.Location = new Point(366, 146);
            lblVNo.Name = "lblVNo";
            lblVNo.Size = new Size(129, 21);
            lblVNo.TabIndex = 0;
            lblVNo.Text = "Vehicle Number";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Bahnschrift", 10.2F);
            lblType.Location = new Point(367, 201);
            lblType.Name = "lblType";
            lblType.Size = new Size(101, 21);
            lblType.TabIndex = 1;
            lblType.Text = "Vehicle Type";
            // 
            // lblCap
            // 
            lblCap.AutoSize = true;
            lblCap.Font = new Font("Bahnschrift", 10.2F);
            lblCap.Location = new Point(367, 267);
            lblCap.Name = "lblCap";
            lblCap.Size = new Size(74, 21);
            lblCap.TabIndex = 2;
            lblCap.Text = "Capacity";
            // 
            // txtVehicleNo
            // 
            txtVehicleNo.Location = new Point(545, 146);
            txtVehicleNo.Name = "txtVehicleNo";
            txtVehicleNo.Size = new Size(176, 27);
            txtVehicleNo.TabIndex = 3;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(545, 265);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(176, 27);
            txtCapacity.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.RosyBrown;
            btnAdd.Font = new Font("Bahnschrift", 10.2F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(785, 107);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 42);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.IndianRed;
            btnUpdate.Font = new Font("Bahnschrift", 10.2F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(785, 162);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 42);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Font = new Font("Bahnschrift", 10.2F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(785, 218);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 42);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvVehicles
            // 
            dgvVehicles.BackgroundColor = Color.White;
            dgvVehicles.BorderStyle = BorderStyle.None;
            dgvVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicles.Location = new Point(366, 334);
            dgvVehicles.Name = "dgvVehicles";
            dgvVehicles.RowHeadersWidth = 51;
            dgvVehicles.Size = new Size(477, 228);
            dgvVehicles.TabIndex = 9;
            dgvVehicles.CellContentClick += dgvVehicles_CellClick;
            // 
            // cmbVehicleType
            // 
            cmbVehicleType.FormattingEnabled = true;
            cmbVehicleType.Items.AddRange(new object[] { "Car", "Van", "Bus" });
            cmbVehicleType.Location = new Point(545, 199);
            cmbVehicleType.Name = "cmbVehicleType";
            cmbVehicleType.Size = new Size(176, 28);
            cmbVehicleType.TabIndex = 10;
            // 
            // lblManageVehicles
            // 
            lblManageVehicles.AutoSize = true;
            lblManageVehicles.Font = new Font("Yu Mincho Demibold", 16.2F, FontStyle.Bold);
            lblManageVehicles.ForeColor = Color.MidnightBlue;
            lblManageVehicles.Location = new Point(449, 38);
            lblManageVehicles.Name = "lblManageVehicles";
            lblManageVehicles.Size = new Size(303, 36);
            lblManageVehicles.TabIndex = 11;
            lblManageVehicles.Text = "MANAGE VEHICLES";
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
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 605);
            panel1.TabIndex = 12;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.Honeydew;
            btnUser.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUser.Location = new Point(50, 39);
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
            btnLogout.Location = new Point(50, 501);
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
            btnVehicles.Location = new Point(50, 125);
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
            btnReports.Location = new Point(50, 409);
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
            btnDrivers.Location = new Point(50, 216);
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
            btnRoutes.Location = new Point(50, 307);
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
            pictureBox2.Size = new Size(251, 605);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Tomato;
            btnClear.Font = new Font("Bahnschrift", 10.2F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(785, 273);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 42);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.MouseCaptureChanged += btnClear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(347, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Manage_Vehicles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(925, 600);
            Controls.Add(pictureBox1);
            Controls.Add(btnClear);
            Controls.Add(panel1);
            Controls.Add(lblManageVehicles);
            Controls.Add(cmbVehicleType);
            Controls.Add(dgvVehicles);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtCapacity);
            Controls.Add(txtVehicleNo);
            Controls.Add(lblCap);
            Controls.Add(lblType);
            Controls.Add(lblVNo);
            Name = "Manage_Vehicles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage_Vehicles";
            Load += Manage_Vehicles_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVNo;
        private Label lblType;
        private Label lblCap;
        private TextBox txtVehicleNo;
        private TextBox txtCapacity;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvVehicles;
        private ComboBox cmbVehicleType;
        private Label lblManageVehicles;
        private Panel panel1;
        private Button btnUser;
        private Button btnLogout;
        private Button btnVehicles;
        private Button btnReports;
        private Button btnDrivers;
        private Button btnRoutes;
        private Button btnClear;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}