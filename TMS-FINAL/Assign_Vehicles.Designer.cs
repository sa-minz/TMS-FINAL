namespace TMS_FINAL
{
    partial class Assign_Vehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assign_Vehicles));
            label1 = new Label();
            txtVehicleType = new Label();
            lblVehicleNo = new Label();
            lblRoute = new Label();
            panel1 = new Panel();
            btnAssignVehicle = new Button();
            btnLogout = new Button();
            btnAssignDriver = new Button();
            btnViewRecords = new Button();
            btnGenerateBill = new Button();
            lblDate = new Label();
            txtVehicleNo = new TextBox();
            cmbVehicleType = new ComboBox();
            cmbRoute = new ComboBox();
            Date = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvAssignVehicles = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssignVehicles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Mincho Demibold", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(444, 44);
            label1.Name = "label1";
            label1.Size = new Size(282, 36);
            label1.TabIndex = 0;
            label1.Text = "ASSIGN VEHICLES";
            // 
            // txtVehicleType
            // 
            txtVehicleType.AutoSize = true;
            txtVehicleType.Font = new Font("Bahnschrift", 10.2F);
            txtVehicleType.Location = new Point(341, 120);
            txtVehicleType.Name = "txtVehicleType";
            txtVehicleType.Size = new Size(101, 21);
            txtVehicleType.TabIndex = 1;
            txtVehicleType.Text = "Vehicle Type";
            // 
            // lblVehicleNo
            // 
            lblVehicleNo.AutoSize = true;
            lblVehicleNo.Font = new Font("Bahnschrift", 10.2F);
            lblVehicleNo.Location = new Point(341, 172);
            lblVehicleNo.Name = "lblVehicleNo";
            lblVehicleNo.Size = new Size(129, 21);
            lblVehicleNo.TabIndex = 2;
            lblVehicleNo.Text = "Vehicle Number";
            // 
            // lblRoute
            // 
            lblRoute.AutoSize = true;
            lblRoute.Font = new Font("Bahnschrift", 10.2F);
            lblRoute.Location = new Point(341, 229);
            lblRoute.Name = "lblRoute";
            lblRoute.Size = new Size(54, 21);
            lblRoute.TabIndex = 3;
            lblRoute.Text = "Route";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(btnAssignVehicle);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnAssignDriver);
            panel1.Controls.Add(btnViewRecords);
            panel1.Controls.Add(btnGenerateBill);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 607);
            panel1.TabIndex = 7;
            // 
            // btnAssignVehicle
            // 
            btnAssignVehicle.BackColor = Color.DarkSlateGray;
            btnAssignVehicle.Font = new Font("Bahnschrift", 9F);
            btnAssignVehicle.ForeColor = Color.White;
            btnAssignVehicle.Location = new Point(49, 55);
            btnAssignVehicle.Name = "btnAssignVehicle";
            btnAssignVehicle.Size = new Size(148, 61);
            btnAssignVehicle.TabIndex = 0;
            btnAssignVehicle.Text = "ASSIGN VEHICLES";
            btnAssignVehicle.UseVisualStyleBackColor = false;
            btnAssignVehicle.Click += btnAssignVehicles_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkSlateGray;
            btnLogout.Font = new Font("Bahnschrift", 9F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(49, 472);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(148, 61);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAssignDriver
            // 
            btnAssignDriver.BackColor = Color.DarkSlateGray;
            btnAssignDriver.Font = new Font("Bahnschrift", 9F);
            btnAssignDriver.ForeColor = Color.White;
            btnAssignDriver.Location = new Point(49, 160);
            btnAssignDriver.Name = "btnAssignDriver";
            btnAssignDriver.Size = new Size(148, 61);
            btnAssignDriver.TabIndex = 1;
            btnAssignDriver.Text = "ASSIGN DRIVERS";
            btnAssignDriver.UseVisualStyleBackColor = false;
            btnAssignDriver.Click += btnAssignDrivers_Click;
            // 
            // btnViewRecords
            // 
            btnViewRecords.BackColor = Color.DarkSlateGray;
            btnViewRecords.Font = new Font("Bahnschrift", 9F);
            btnViewRecords.ForeColor = Color.White;
            btnViewRecords.Location = new Point(49, 362);
            btnViewRecords.Name = "btnViewRecords";
            btnViewRecords.Size = new Size(148, 61);
            btnViewRecords.TabIndex = 3;
            btnViewRecords.Text = "VIEW RECORDS";
            btnViewRecords.UseVisualStyleBackColor = false;
            btnViewRecords.Click += btnViewRecords_Click;
            // 
            // btnGenerateBill
            // 
            btnGenerateBill.BackColor = Color.DarkSlateGray;
            btnGenerateBill.Font = new Font("Bahnschrift", 9F);
            btnGenerateBill.ForeColor = Color.White;
            btnGenerateBill.Location = new Point(49, 261);
            btnGenerateBill.Name = "btnGenerateBill";
            btnGenerateBill.Size = new Size(148, 61);
            btnGenerateBill.TabIndex = 2;
            btnGenerateBill.Text = "GENERATE BILLS";
            btnGenerateBill.UseVisualStyleBackColor = false;
            btnGenerateBill.Click += btnGenerateBills_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Bahnschrift", 10.2F);
            lblDate.Location = new Point(341, 281);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(45, 21);
            lblDate.TabIndex = 8;
            lblDate.Text = "Date";
            // 
            // txtVehicleNo
            // 
            txtVehicleNo.Location = new Point(512, 166);
            txtVehicleNo.Name = "txtVehicleNo";
            txtVehicleNo.Size = new Size(176, 27);
            txtVehicleNo.TabIndex = 9;
            // 
            // cmbVehicleType
            // 
            cmbVehicleType.FormattingEnabled = true;
            cmbVehicleType.Items.AddRange(new object[] { "Car", "Van", "Bus" });
            cmbVehicleType.Location = new Point(512, 113);
            cmbVehicleType.Name = "cmbVehicleType";
            cmbVehicleType.Size = new Size(176, 28);
            cmbVehicleType.TabIndex = 11;
            // 
            // cmbRoute
            // 
            cmbRoute.FormattingEnabled = true;
            cmbRoute.Items.AddRange(new object[] { "Colombo-Kandy", "Colombo-Galle", "NuwaraEliya-Colombo" });
            cmbRoute.Location = new Point(512, 227);
            cmbRoute.Name = "cmbRoute";
            cmbRoute.Size = new Size(176, 28);
            cmbRoute.TabIndex = 12;
            // 
            // Date
            // 
            Date.Location = new Point(512, 281);
            Date.Name = "Date";
            Date.Size = new Size(176, 27);
            Date.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Tomato;
            btnAdd.Font = new Font("Bahnschrift", 10.2F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(778, 104);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 42);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightCoral;
            btnUpdate.Font = new Font("Bahnschrift", 10.2F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(778, 161);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 42);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Font = new Font("Bahnschrift", 10.2F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(778, 218);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 42);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.RosyBrown;
            btnClear.Font = new Font("Bahnschrift", 10.2F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(778, 274);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 42);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvAssignVehicles
            // 
            dgvAssignVehicles.BackgroundColor = Color.White;
            dgvAssignVehicles.BorderStyle = BorderStyle.None;
            dgvAssignVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssignVehicles.Location = new Point(341, 351);
            dgvAssignVehicles.Name = "dgvAssignVehicles";
            dgvAssignVehicles.RowHeadersWidth = 51;
            dgvAssignVehicles.Size = new Size(491, 216);
            dgvAssignVehicles.TabIndex = 19;
            dgvAssignVehicles.CellContentClick += dgvAssignVehicles_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(341, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 607);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Assign_Vehicles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(925, 600);
            Controls.Add(pictureBox1);
            Controls.Add(dgvAssignVehicles);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(Date);
            Controls.Add(cmbRoute);
            Controls.Add(cmbVehicleType);
            Controls.Add(txtVehicleNo);
            Controls.Add(lblDate);
            Controls.Add(panel1);
            Controls.Add(lblRoute);
            Controls.Add(lblVehicleNo);
            Controls.Add(txtVehicleType);
            Controls.Add(label1);
            Name = "Assign_Vehicles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assign_Vehicles";
            Load += Assign_Vehicles_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAssignVehicles).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txtVehicleType;
        private Label lblVehicleNo;
        private Label lblRoute;
        private Panel panel1;
        private Button btnAssignVehicle;
        private Button btnLogout;
        private Button btnAssignDriver;
        private Button btnViewRecords;
        private Button btnGenerateBill;
        private Label lblDate;
        private TextBox txtVehicleNo;
        private ComboBox cmbVehicleType;
        private ComboBox cmbRoute;
        private DateTimePicker Date;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvAssignVehicles;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}