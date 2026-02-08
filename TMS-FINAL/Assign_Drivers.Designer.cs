namespace TMS_FINAL
{
    partial class Assign_Drivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assign_Drivers));
            panel1 = new Panel();
            btnAssignVehicle = new Button();
            btnLogout = new Button();
            btnAssignDriver = new Button();
            btnViewRecord = new Button();
            btnGenerateBill = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            lblDriverName = new Label();
            lblVehicleType = new Label();
            lblVehicleNo = new Label();
            lblContactNo = new Label();
            lblRoute = new Label();
            cmbDriver = new ComboBox();
            cmbVehicleType = new ComboBox();
            txtVehicleNo = new TextBox();
            cmbRoute = new ComboBox();
            Date = new DateTimePicker();
            dgvAssignDrivers = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            lblAssignDate = new Label();
            pictureBox1 = new PictureBox();
            txtContactNo = new MaskedTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAssignDrivers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(btnAssignVehicle);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnAssignDriver);
            panel1.Controls.Add(btnViewRecord);
            panel1.Controls.Add(btnGenerateBill);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 607);
            panel1.TabIndex = 8;
            // 
            // btnAssignVehicle
            // 
            btnAssignVehicle.BackColor = Color.DarkSlateGray;
            btnAssignVehicle.Font = new Font("Bahnschrift", 9F);
            btnAssignVehicle.ForeColor = Color.White;
            btnAssignVehicle.Location = new Point(49, 59);
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
            btnAssignDriver.Location = new Point(49, 151);
            btnAssignDriver.Name = "btnAssignDriver";
            btnAssignDriver.Size = new Size(148, 61);
            btnAssignDriver.TabIndex = 1;
            btnAssignDriver.Text = "ASSIGN DRIVERS";
            btnAssignDriver.UseVisualStyleBackColor = false;
            btnAssignDriver.Click += btnAssignVehicles_Click;
            // 
            // btnViewRecord
            // 
            btnViewRecord.BackColor = Color.DarkSlateGray;
            btnViewRecord.Font = new Font("Bahnschrift", 9F);
            btnViewRecord.ForeColor = Color.White;
            btnViewRecord.Location = new Point(49, 368);
            btnViewRecord.Name = "btnViewRecord";
            btnViewRecord.Size = new Size(148, 61);
            btnViewRecord.TabIndex = 3;
            btnViewRecord.Text = "VIEW RECORDS";
            btnViewRecord.UseVisualStyleBackColor = false;
            btnViewRecord.Click += btnViewRecords_Click;
            // 
            // btnGenerateBill
            // 
            btnGenerateBill.BackColor = Color.DarkSlateGray;
            btnGenerateBill.Font = new Font("Bahnschrift", 9F);
            btnGenerateBill.ForeColor = Color.White;
            btnGenerateBill.Location = new Point(49, 265);
            btnGenerateBill.Name = "btnGenerateBill";
            btnGenerateBill.Size = new Size(148, 61);
            btnGenerateBill.TabIndex = 2;
            btnGenerateBill.Text = "GENERATE BILLS";
            btnGenerateBill.UseVisualStyleBackColor = false;
            btnGenerateBill.Click += btnGenerateBills_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 604);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Mincho Demibold", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(466, 34);
            label1.Name = "label1";
            label1.Size = new Size(265, 36);
            label1.TabIndex = 9;
            label1.Text = "ASSIGN DRIVERS";
            // 
            // lblDriverName
            // 
            lblDriverName.AutoSize = true;
            lblDriverName.Font = new Font("Bahnschrift", 10.2F);
            lblDriverName.Location = new Point(320, 105);
            lblDriverName.Name = "lblDriverName";
            lblDriverName.Size = new Size(107, 21);
            lblDriverName.TabIndex = 10;
            lblDriverName.Text = "Driver Name";
            // 
            // lblVehicleType
            // 
            lblVehicleType.AutoSize = true;
            lblVehicleType.Font = new Font("Bahnschrift", 10.2F);
            lblVehicleType.Location = new Point(320, 191);
            lblVehicleType.Name = "lblVehicleType";
            lblVehicleType.Size = new Size(101, 21);
            lblVehicleType.TabIndex = 11;
            lblVehicleType.Text = "Vehicle Type";
            // 
            // lblVehicleNo
            // 
            lblVehicleNo.AutoSize = true;
            lblVehicleNo.Font = new Font("Bahnschrift", 10.2F);
            lblVehicleNo.Location = new Point(320, 231);
            lblVehicleNo.Name = "lblVehicleNo";
            lblVehicleNo.Size = new Size(129, 21);
            lblVehicleNo.TabIndex = 12;
            lblVehicleNo.Text = "Vehicle Number";
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Font = new Font("Bahnschrift", 10.2F);
            lblContactNo.Location = new Point(320, 145);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(134, 21);
            lblContactNo.TabIndex = 13;
            lblContactNo.Text = "Contact Number";
            // 
            // lblRoute
            // 
            lblRoute.AutoSize = true;
            lblRoute.Font = new Font("Bahnschrift", 10.2F);
            lblRoute.Location = new Point(320, 272);
            lblRoute.Name = "lblRoute";
            lblRoute.Size = new Size(54, 21);
            lblRoute.TabIndex = 14;
            lblRoute.Text = "Route";
            // 
            // cmbDriver
            // 
            cmbDriver.FormattingEnabled = true;
            cmbDriver.Location = new Point(537, 98);
            cmbDriver.Name = "cmbDriver";
            cmbDriver.Size = new Size(176, 28);
            cmbDriver.TabIndex = 15;
            // 
            // cmbVehicleType
            // 
            cmbVehicleType.FormattingEnabled = true;
            cmbVehicleType.Items.AddRange(new object[] { "Car", "Van", "Bus" });
            cmbVehicleType.Location = new Point(537, 184);
            cmbVehicleType.Name = "cmbVehicleType";
            cmbVehicleType.Size = new Size(176, 28);
            cmbVehicleType.TabIndex = 16;
            // 
            // txtVehicleNo
            // 
            txtVehicleNo.Location = new Point(537, 229);
            txtVehicleNo.Name = "txtVehicleNo";
            txtVehicleNo.Size = new Size(176, 27);
            txtVehicleNo.TabIndex = 17;
            // 
            // cmbRoute
            // 
            cmbRoute.FormattingEnabled = true;
            cmbRoute.Location = new Point(537, 265);
            cmbRoute.Name = "cmbRoute";
            cmbRoute.Size = new Size(176, 28);
            cmbRoute.TabIndex = 18;
            cmbRoute.SelectedIndexChanged += cmbRoute_SelectedIndexChanged;
            // 
            // Date
            // 
            Date.Location = new Point(537, 316);
            Date.Name = "Date";
            Date.Size = new Size(176, 27);
            Date.TabIndex = 19;
            // 
            // dgvAssignDrivers
            // 
            dgvAssignDrivers.BackgroundColor = Color.White;
            dgvAssignDrivers.BorderStyle = BorderStyle.None;
            dgvAssignDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssignDrivers.Location = new Point(277, 387);
            dgvAssignDrivers.Name = "dgvAssignDrivers";
            dgvAssignDrivers.RowHeadersWidth = 51;
            dgvAssignDrivers.Size = new Size(615, 175);
            dgvAssignDrivers.TabIndex = 20;
            dgvAssignDrivers.CellContentClick += dgvAssignDrivers_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Tomato;
            btnAdd.Font = new Font("Bahnschrift", 10.2F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(783, 119);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 42);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightCoral;
            btnUpdate.Font = new Font("Bahnschrift", 10.2F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(783, 175);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 42);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Font = new Font("Bahnschrift", 10.2F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(783, 229);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 42);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.RosyBrown;
            btnClear.Font = new Font("Bahnschrift", 10.2F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(783, 284);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 42);
            btnClear.TabIndex = 24;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblAssignDate
            // 
            lblAssignDate.AutoSize = true;
            lblAssignDate.Font = new Font("Bahnschrift", 10.2F);
            lblAssignDate.Location = new Point(320, 320);
            lblAssignDate.Name = "lblAssignDate";
            lblAssignDate.Size = new Size(101, 21);
            lblAssignDate.TabIndex = 25;
            lblAssignDate.Text = "Assign Date";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(371, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(537, 145);
            txtContactNo.Mask = "+00-000000000";
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(176, 27);
            txtContactNo.TabIndex = 28;
            // 
            // Assign_Drivers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(925, 600);
            Controls.Add(txtContactNo);
            Controls.Add(pictureBox1);
            Controls.Add(lblAssignDate);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvAssignDrivers);
            Controls.Add(Date);
            Controls.Add(cmbRoute);
            Controls.Add(txtVehicleNo);
            Controls.Add(cmbVehicleType);
            Controls.Add(cmbDriver);
            Controls.Add(lblRoute);
            Controls.Add(lblContactNo);
            Controls.Add(lblVehicleNo);
            Controls.Add(lblVehicleType);
            Controls.Add(lblDriverName);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Assign_Drivers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assign_Drivers";
            Load += Assign_Drivers_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAssignDrivers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnAssignVehicle;
        private Button btnLogout;
        private Button btnAssignDriver;
        private Button btnViewRecord;
        private Button btnGenerateBill;
        private Label label1;
        private Label lblDriverName;
        private Label lblVehicleType;
        private Label lblVehicleNo;
        private Label lblContactNo;
        private Label lblRoute;
        private ComboBox cmbDriver;
        private ComboBox cmbVehicleType;
        private TextBox txtVehicleNo;
        private ComboBox cmbRoute;
        private DateTimePicker Date;
        private DataGridView dgvAssignDrivers;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Label lblAssignDate;
        private PictureBox pictureBox1;
        private MaskedTextBox txtContactNo;
        private PictureBox pictureBox2;
    }
}