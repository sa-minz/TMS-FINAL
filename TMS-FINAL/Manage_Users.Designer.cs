namespace TMS_FINAL
{
    partial class Manage_Users
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Users));
            lblName = new Label();
            lblUsername = new Label();
            lblRole = new Label();
            lblTitle = new Label();
            txtName = new TextBox();
            txtUsername = new TextBox();
            cbRole = new ComboBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            dgvUsers = new DataGridView();
            lblPassword = new Label();
            txtPassword = new TextBox();
            panel1 = new Panel();
            btnLogout = new Button();
            btnUser = new Button();
            btnReports = new Button();
            btnVehicles = new Button();
            btnRoutes = new Button();
            btnDrivers = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.White;
            lblName.Font = new Font("Bahnschrift", 10.2F);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(341, 111);
            lblName.Name = "lblName";
            lblName.Size = new Size(55, 21);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Bahnschrift", 10.2F);
            lblUsername.Location = new Point(341, 169);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(88, 21);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Bahnschrift", 10.2F);
            lblRole.Location = new Point(341, 275);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(44, 21);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Yu Mincho Demibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(495, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(251, 36);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "MANAGE USERS";
            // 
            // txtName
            // 
            txtName.Location = new Point(513, 109);
            txtName.Name = "txtName";
            txtName.Size = new Size(176, 27);
            txtName.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(513, 163);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(176, 27);
            txtUsername.TabIndex = 5;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "Staff" });
            cbRole.Location = new Point(513, 273);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(176, 28);
            cbRole.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.RosyBrown;
            btnAdd.Font = new Font("Bahnschrift", 10.2F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(783, 90);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 42);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Font = new Font("Bahnschrift", 10.2F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(783, 207);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 42);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.IndianRed;
            btnUpdate.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(783, 148);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 42);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Tomato;
            btnClear.Font = new Font("Bahnschrift", 10.2F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(783, 275);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 42);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvUsers
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsers.GridColor = Color.White;
            dgvUsers.Location = new Point(313, 339);
            dgvUsers.Name = "dgvUsers";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;

            dgvUsers.Size = new Size(579, 249);
            dgvUsers.TabIndex = 12;
            dgvUsers.CellContentClick += dgvUsers_CellClick;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Bahnschrift", 10.2F);
            lblPassword.Location = new Point(341, 222);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 21);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(513, 222);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(176, 27);
            txtPassword.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(btnVehicles);
            panel1.Controls.Add(btnRoutes);
            panel1.Controls.Add(btnDrivers);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 607);
            panel1.TabIndex = 15;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Honeydew;
            btnLogout.Font = new Font("Bahnschrift", 9F);
            btnLogout.ForeColor = Color.Black;
            btnLogout.Location = new Point(45, 513);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(148, 61);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.Honeydew;
            btnUser.Font = new Font("Bahnschrift", 9F);
            btnUser.ForeColor = Color.Black;
            btnUser.Location = new Point(45, 36);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(148, 61);
            btnUser.TabIndex = 0;
            btnUser.Text = "MANAGE USERS";
            btnUser.UseVisualStyleBackColor = false;
          
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Honeydew;
            btnReports.Font = new Font("Bahnschrift", 9F);
            btnReports.ForeColor = Color.Black;
            btnReports.Location = new Point(45, 412);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(148, 61);
            btnReports.TabIndex = 4;
            btnReports.Text = "MANAGE REPORTS";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnVehicles
            // 
            btnVehicles.BackColor = Color.Honeydew;
            btnVehicles.Font = new Font("Bahnschrift", 9F);
            btnVehicles.ForeColor = Color.Black;
            btnVehicles.Location = new Point(45, 122);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new Size(148, 61);
            btnVehicles.TabIndex = 1;
            btnVehicles.Text = "MANAGE VEHICLE";
            btnVehicles.UseVisualStyleBackColor = false;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // btnRoutes
            // 
            btnRoutes.BackColor = Color.Honeydew;
            btnRoutes.Font = new Font("Bahnschrift", 9F);
            btnRoutes.ForeColor = Color.Black;
            btnRoutes.Location = new Point(45, 312);
            btnRoutes.Name = "btnRoutes";
            btnRoutes.Size = new Size(148, 61);
            btnRoutes.TabIndex = 3;
            btnRoutes.Text = "MANAGE ROUTES";
            btnRoutes.UseVisualStyleBackColor = false;
            btnRoutes.Click += btnRoutes_Click;
            // 
            // btnDrivers
            // 
            btnDrivers.BackColor = Color.Honeydew;
            btnDrivers.Font = new Font("Bahnschrift", 9F);
            btnDrivers.ForeColor = Color.Black;
            btnDrivers.Location = new Point(45, 222);
            btnDrivers.Name = "btnDrivers";
            btnDrivers.Size = new Size(148, 61);
            btnDrivers.TabIndex = 2;
            btnDrivers.Text = "MANAGE DRIVERS";
            btnDrivers.UseVisualStyleBackColor = false;
            btnDrivers.Click += btnDrivers_Click;
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
            pictureBox1.Location = new Point(416, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Manage_Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(925, 600);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(dgvUsers);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(cbRole);
            Controls.Add(txtUsername);
            Controls.Add(txtName);
            Controls.Add(lblTitle);
            Controls.Add(lblRole);
            Controls.Add(lblUsername);
            Controls.Add(lblName);
            Name = "Manage_Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage_Users";
            Load += Manage_Users_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblUsername;
        private Label lblRole;
        private Label lblTitle;
        private TextBox txtName;
        private TextBox txtUsername;
        private ComboBox cbRole;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private DataGridView dgvUsers;
        private Label lblPassword;
        private TextBox txtPassword;
        private Panel panel1;
        private Button btnUser;
        private Button btnLogout;
        private Button btnVehicles;
        private Button btnReports;
        private Button btnDrivers;
        private Button btnRoutes;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}