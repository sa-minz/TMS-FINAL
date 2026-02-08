namespace TMS_FINAL
{
    partial class View_Records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Records));
            panel1 = new Panel();
            btnAssignVehicle = new Button();
            btnLogout = new Button();
            btnAssignDriver = new Button();
            btnViewRecord = new Button();
            btnGenerateBill = new Button();
            lblViewRecords = new Label();
            panel2 = new Panel();
            btnPrint = new Button();
            btnClear = new Button();
            btnFilter = new Button();
            ToDate = new DateTimePicker();
            FromDate = new DateTimePicker();
            cmbType = new ComboBox();
            dgvViewRecords = new DataGridView();
            lblTo = new Label();
            lblFrom = new Label();
            lblType = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 604);
            panel1.TabIndex = 9;
            // 
            // btnAssignVehicle
            // 
            btnAssignVehicle.BackColor = Color.DarkSlateGray;
            btnAssignVehicle.Font = new Font("Bahnschrift", 9F);
            btnAssignVehicle.ForeColor = Color.White;
            btnAssignVehicle.Location = new Point(53, 81);
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
            btnLogout.Location = new Point(53, 490);
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
            btnAssignDriver.Location = new Point(53, 178);
            btnAssignDriver.Name = "btnAssignDriver";
            btnAssignDriver.Size = new Size(148, 61);
            btnAssignDriver.TabIndex = 1;
            btnAssignDriver.Text = "ASSIGN DRIVERS";
            btnAssignDriver.UseVisualStyleBackColor = false;
            btnAssignDriver.Click += btnAssignDrivers_Click;
            // 
            // btnViewRecord
            // 
            btnViewRecord.BackColor = Color.DarkSlateGray;
            btnViewRecord.Font = new Font("Bahnschrift", 9F);
            btnViewRecord.ForeColor = Color.White;
            btnViewRecord.Location = new Point(53, 388);
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
            btnGenerateBill.Location = new Point(53, 287);
            btnGenerateBill.Name = "btnGenerateBill";
            btnGenerateBill.Size = new Size(148, 61);
            btnGenerateBill.TabIndex = 2;
            btnGenerateBill.Text = "GENERATE BILLS";
            btnGenerateBill.UseVisualStyleBackColor = false;
            btnGenerateBill.Click += btnGenerateBill_Click;
            // 
            // lblViewRecords
            // 
            lblViewRecords.AutoSize = true;
            lblViewRecords.Font = new Font("Yu Mincho Demibold", 16.2F, FontStyle.Bold);
            lblViewRecords.ForeColor = Color.MidnightBlue;
            lblViewRecords.Location = new Point(479, 35);
            lblViewRecords.Name = "lblViewRecords";
            lblViewRecords.Size = new Size(245, 36);
            lblViewRecords.TabIndex = 10;
            lblViewRecords.Text = "VIEW RECORDS";
            lblViewRecords.Click += lblViewRecords_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPrint);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnFilter);
            panel2.Controls.Add(ToDate);
            panel2.Controls.Add(FromDate);
            panel2.Controls.Add(cmbType);
            panel2.Controls.Add(dgvViewRecords);
            panel2.Controls.Add(lblTo);
            panel2.Controls.Add(lblFrom);
            panel2.Controls.Add(lblType);
            panel2.Location = new Point(323, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(552, 495);
            panel2.TabIndex = 11;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.IndianRed;
            btnPrint.Font = new Font("Bahnschrift", 10.2F);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(398, 438);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(109, 42);
            btnPrint.TabIndex = 12;
            btnPrint.Text = "Export";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnExportCSV_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightCoral;
            btnClear.Font = new Font("Bahnschrift", 10.2F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(398, 141);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 42);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Tomato;
            btnFilter.Font = new Font("Bahnschrift", 10.2F);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(398, 83);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(109, 42);
            btnFilter.TabIndex = 7;
            btnFilter.Text = "Search";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnSearch_Click;
            // 
            // ToDate
            // 
            ToDate.Location = new Point(160, 148);
            ToDate.Name = "ToDate";
            ToDate.Size = new Size(176, 27);
            ToDate.TabIndex = 6;
            // 
            // FromDate
            // 
            FromDate.Location = new Point(160, 98);
            FromDate.Name = "FromDate";
            FromDate.Size = new Size(176, 27);
            FromDate.TabIndex = 5;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Assigned  Vehicles", "Assigned  Drivers" });
            cmbType.Location = new Point(160, 47);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(176, 28);
            cmbType.TabIndex = 4;
            // 
            // dgvViewRecords
            // 
            dgvViewRecords.BackgroundColor = Color.White;
            dgvViewRecords.BorderStyle = BorderStyle.None;
            dgvViewRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewRecords.Location = new Point(3, 239);
            dgvViewRecords.Name = "dgvViewRecords";
            dgvViewRecords.RowHeadersWidth = 51;
            dgvViewRecords.Size = new Size(546, 179);
            dgvViewRecords.TabIndex = 3;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Bahnschrift", 10.2F);
            lblTo.Location = new Point(55, 153);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(26, 21);
            lblTo.TabIndex = 2;
            lblTo.Text = "To";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Bahnschrift", 10.2F);
            lblFrom.Location = new Point(46, 98);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(51, 21);
            lblFrom.TabIndex = 1;
            lblFrom.Text = "From";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Bahnschrift", 10.2F);
            lblType.Location = new Point(46, 47);
            lblType.Name = "lblType";
            lblType.Size = new Size(43, 21);
            lblType.TabIndex = 0;
            lblType.Text = "Type";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(386, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
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
            // View_Records
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(925, 600);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(lblViewRecords);
            Controls.Add(panel1);
            Name = "View_Records";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_Records";
            Load += View_Records_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label lblViewRecords;
        private Panel panel2;
        private DateTimePicker ToDate;
        private DateTimePicker FromDate;
        private ComboBox cmbType;
        private DataGridView dgvViewRecords;
        private Label lblTo;
        private Label lblFrom;
        private Label lblType;
        private Button btnPrint;
        private Button btnFilter;
        private Button btnClear;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}