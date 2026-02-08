namespace TMS_FINAL
{
    partial class Generate_Bills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generate_Bills));
            panel1 = new Panel();
            btnAssign = new Button();
            btnLogout = new Button();
            btnAssignDriver = new Button();
            btnViewRecord = new Button();
            btnGenerateBill = new Button();
            lblGenerateBill = new Label();
            panel2 = new Panel();
            cmbRoute = new ComboBox();
            BillDate = new DateTimePicker();
            txtDistance = new TextBox();
            cmbVehicleType = new ComboBox();
            btnGenerate = new Button();
            txtTotal = new TextBox();
            txtRate = new TextBox();
            btnClear = new Button();
            btnCalculate = new Button();
            lblTotal = new Label();
            lblRate = new Label();
            lblDistance = new Label();
            lblBillDate = new Label();
            lblRoute = new Label();
            lblVehicleType = new Label();
            dgvGenerateBill = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGenerateBill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(btnAssign);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnAssignDriver);
            panel1.Controls.Add(btnViewRecord);
            panel1.Controls.Add(btnGenerateBill);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 604);
            panel1.TabIndex = 6;
            // 
            // btnAssign
            // 
            btnAssign.BackColor = Color.DarkSlateGray;
            btnAssign.Font = new Font("Bahnschrift", 9F);
            btnAssign.ForeColor = Color.White;
            btnAssign.Location = new Point(49, 66);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(148, 61);
            btnAssign.TabIndex = 0;
            btnAssign.Text = "ASSIGN VEHICLES";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += btnAssign_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkSlateGray;
            btnLogout.Font = new Font("Bahnschrift", 9F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(49, 481);
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
            btnAssignDriver.Location = new Point(49, 174);
            btnAssignDriver.Name = "btnAssignDriver";
            btnAssignDriver.Size = new Size(148, 61);
            btnAssignDriver.TabIndex = 1;
            btnAssignDriver.Text = "ASSIGN DRIVERS";
            btnAssignDriver.UseVisualStyleBackColor = false;
            btnAssignDriver.Click += btnAssignDriver_Click;
            // 
            // btnViewRecord
            // 
            btnViewRecord.BackColor = Color.DarkSlateGray;
            btnViewRecord.Font = new Font("Bahnschrift", 9F);
            btnViewRecord.ForeColor = Color.White;
            btnViewRecord.Location = new Point(49, 377);
            btnViewRecord.Name = "btnViewRecord";
            btnViewRecord.Size = new Size(148, 61);
            btnViewRecord.TabIndex = 3;
            btnViewRecord.Text = "VIEW RECORDS";
            btnViewRecord.UseVisualStyleBackColor = false;
            btnViewRecord.Click += btnViewRecord_Click;
            // 
            // btnGenerateBill
            // 
            btnGenerateBill.BackColor = Color.DarkSlateGray;
            btnGenerateBill.Font = new Font("Bahnschrift", 9F);
            btnGenerateBill.ForeColor = Color.White;
            btnGenerateBill.Location = new Point(49, 272);
            btnGenerateBill.Name = "btnGenerateBill";
            btnGenerateBill.Size = new Size(148, 61);
            btnGenerateBill.TabIndex = 2;
            btnGenerateBill.Text = "GENERATE BILLS";
            btnGenerateBill.UseVisualStyleBackColor = false;
            btnGenerateBill.Click += btnGenerateBill_Click;
            // 
            // lblGenerateBill
            // 
            lblGenerateBill.AutoSize = true;
            lblGenerateBill.Font = new Font("Yu Mincho Demibold", 16.2F, FontStyle.Bold);
            lblGenerateBill.ForeColor = Color.MidnightBlue;
            lblGenerateBill.Location = new Point(479, 30);
            lblGenerateBill.Name = "lblGenerateBill";
            lblGenerateBill.Size = new Size(269, 36);
            lblGenerateBill.TabIndex = 7;
            lblGenerateBill.Text = "GENERATE BILLS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(cmbRoute);
            panel2.Controls.Add(BillDate);
            panel2.Controls.Add(txtDistance);
            panel2.Controls.Add(cmbVehicleType);
            panel2.Controls.Add(btnGenerate);
            panel2.Controls.Add(txtTotal);
            panel2.Controls.Add(txtRate);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnCalculate);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(lblRate);
            panel2.Controls.Add(lblDistance);
            panel2.Controls.Add(lblBillDate);
            panel2.Controls.Add(lblRoute);
            panel2.Controls.Add(lblVehicleType);
            panel2.Location = new Point(262, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(651, 314);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // cmbRoute
            // 
            cmbRoute.FormattingEnabled = true;
            cmbRoute.Location = new Point(309, 77);
            cmbRoute.Name = "cmbRoute";
            cmbRoute.Size = new Size(176, 28);
            cmbRoute.TabIndex = 14;
            cmbRoute.Click += Generate_Bills_Load;
            // 
            // BillDate
            // 
            BillDate.Location = new Point(309, 120);
            BillDate.Name = "BillDate";
            BillDate.Size = new Size(176, 27);
            BillDate.TabIndex = 13;
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(309, 164);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(176, 27);
            txtDistance.TabIndex = 12;
            // 
            // cmbVehicleType
            // 
            cmbVehicleType.FormattingEnabled = true;
            cmbVehicleType.Items.AddRange(new object[] { "Car", "Van", "Bus" });
            cmbVehicleType.Location = new Point(309, 30);
            cmbVehicleType.Name = "cmbVehicleType";
            cmbVehicleType.Size = new Size(176, 28);
            cmbVehicleType.TabIndex = 11;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.IndianRed;
            btnGenerate.Font = new Font("Bahnschrift", 10.2F);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(530, 209);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(109, 63);
            btnGenerate.TabIndex = 7;
            btnGenerate.Text = "Generate Bill";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(309, 251);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(176, 27);
            txtTotal.TabIndex = 10;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(309, 203);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(176, 27);
            txtRate.TabIndex = 9;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightCoral;
            btnClear.Font = new Font("Bahnschrift", 10.2F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(530, 140);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 42);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Tomato;
            btnCalculate.Font = new Font("Bahnschrift", 10.2F);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(530, 73);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(109, 42);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Save";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Bahnschrift", 10.2F);
            lblTotal.Location = new Point(108, 257);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(46, 21);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Font = new Font("Bahnschrift", 10.2F);
            lblRate.Location = new Point(108, 209);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(105, 21);
            lblRate.TabIndex = 4;
            lblRate.Text = "Rate Per KM";
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Font = new Font("Bahnschrift", 10.2F);
            lblDistance.Location = new Point(108, 170);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(111, 21);
            lblDistance.TabIndex = 3;
            lblDistance.Text = "Distance(KM)";
            // 
            // lblBillDate
            // 
            lblBillDate.AutoSize = true;
            lblBillDate.Font = new Font("Bahnschrift", 10.2F);
            lblBillDate.Location = new Point(108, 126);
            lblBillDate.Name = "lblBillDate";
            lblBillDate.Size = new Size(75, 21);
            lblBillDate.TabIndex = 2;
            lblBillDate.Text = "Bill Date";
            // 
            // lblRoute
            // 
            lblRoute.AutoSize = true;
            lblRoute.Font = new Font("Bahnschrift", 10.2F);
            lblRoute.Location = new Point(108, 84);
            lblRoute.Name = "lblRoute";
            lblRoute.Size = new Size(54, 21);
            lblRoute.TabIndex = 1;
            lblRoute.Text = "Route";
            // 
            // lblVehicleType
            // 
            lblVehicleType.AutoSize = true;
            lblVehicleType.Font = new Font("Bahnschrift", 10.2F);
            lblVehicleType.Location = new Point(108, 37);
            lblVehicleType.Name = "lblVehicleType";
            lblVehicleType.Size = new Size(101, 21);
            lblVehicleType.TabIndex = 0;
            lblVehicleType.Text = "Vehicle Type";
            // 
            // dgvGenerateBill
            // 
            dgvGenerateBill.BackgroundColor = Color.White;
            dgvGenerateBill.BorderStyle = BorderStyle.None;
            dgvGenerateBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGenerateBill.Location = new Point(288, 424);
            dgvGenerateBill.Name = "dgvGenerateBill";
            dgvGenerateBill.RowHeadersWidth = 51;
            dgvGenerateBill.Size = new Size(597, 134);
            dgvGenerateBill.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(400, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 604);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Generate_Bills
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(925, 600);
            Controls.Add(pictureBox1);
            Controls.Add(dgvGenerateBill);
            Controls.Add(panel2);
            Controls.Add(lblGenerateBill);
            Controls.Add(panel1);
            Name = "Generate_Bills";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generate_Bills";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGenerateBill).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnAssign;
        private Button btnLogout;
        private Button btnAssignDriver;
        private Button btnViewRecord;
        private Button btnGenerateBill;
        private Label lblGenerateBill;
        private Panel panel2;
        private ComboBox cmbRoute;
        private DateTimePicker BillDate;
        private TextBox txtDistance;
        private ComboBox cmbVehicleType;
        private TextBox txtTotal;
        private TextBox txtRate;
        private Button btnClear;
        private Button btnGenerate;
        private Button btnCalculate;
        private Label lblTotal;
        private Label lblRate;
        private Label lblDistance;
        private Label lblBillDate;
        private Label lblRoute;
        private Label lblVehicleType;
        private DataGridView dgvGenerateBill;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}