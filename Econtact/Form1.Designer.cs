namespace Econtact
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lblContactID = new Label();
            txtboxContactID = new TextBox();
            txtBoxContactNumber = new TextBox();
            lblContactNo = new Label();
            txtboxLastName = new TextBox();
            lblLastName = new Label();
            txtboxFirstName = new TextBox();
            lblfirstname = new Label();
            txtboxAddress = new TextBox();
            lblAddress = new Label();
            cmbGender = new ComboBox();
            lblGender = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvContactList = new DataGridView();
            txtboxSearch = new TextBox();
            pictureBox2 = new PictureBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvContactList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(529, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblContactID
            // 
            lblContactID.AutoSize = true;
            lblContactID.Location = new Point(118, 141);
            lblContactID.Name = "lblContactID";
            lblContactID.Size = new Size(63, 15);
            lblContactID.TabIndex = 1;
            lblContactID.Text = "Contact ID";
            // 
            // txtboxContactID
            // 
            txtboxContactID.Location = new Point(187, 138);
            txtboxContactID.Name = "txtboxContactID";
            txtboxContactID.Size = new Size(180, 23);
            txtboxContactID.TabIndex = 2;
            // 
            // txtBoxContactNumber
            // 
            txtBoxContactNumber.Location = new Point(187, 252);
            txtBoxContactNumber.Name = "txtBoxContactNumber";
            txtBoxContactNumber.Size = new Size(180, 23);
            txtBoxContactNumber.TabIndex = 4;
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Location = new Point(118, 255);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(68, 15);
            lblContactNo.TabIndex = 3;
            lblContactNo.Text = "Contact No";
            // 
            // txtboxLastName
            // 
            txtboxLastName.Location = new Point(187, 213);
            txtboxLastName.Name = "txtboxLastName";
            txtboxLastName.Size = new Size(180, 23);
            txtboxLastName.TabIndex = 6;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(118, 216);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            // 
            // txtboxFirstName
            // 
            txtboxFirstName.Location = new Point(187, 175);
            txtboxFirstName.Name = "txtboxFirstName";
            txtboxFirstName.Size = new Size(180, 23);
            txtboxFirstName.TabIndex = 8;
            // 
            // lblfirstname
            // 
            lblfirstname.AutoSize = true;
            lblfirstname.Location = new Point(118, 178);
            lblfirstname.Name = "lblfirstname";
            lblfirstname.Size = new Size(64, 15);
            lblfirstname.TabIndex = 7;
            lblfirstname.Text = "First Name";
            // 
            // txtboxAddress
            // 
            txtboxAddress.Location = new Point(187, 297);
            txtboxAddress.Multiline = true;
            txtboxAddress.Name = "txtboxAddress";
            txtboxAddress.Size = new Size(180, 124);
            txtboxAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(118, 297);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Address";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(187, 440);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(180, 23);
            cmbGender.TabIndex = 11;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(122, 443);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(45, 15);
            lblGender.TabIndex = 12;
            lblGender.Text = "Gender";
            lblGender.Click += label1_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(101, 515);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 34);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.RoyalBlue;
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(230, 515);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 34);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(343, 515);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 34);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Orange;
            btnClear.ForeColor = SystemColors.ButtonFace;
            btnClear.Location = new Point(464, 515);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 34);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // dgvContactList
            // 
            dgvContactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactList.Location = new Point(421, 166);
            dgvContactList.Name = "dgvContactList";
            dgvContactList.Size = new Size(680, 292);
            dgvContactList.TabIndex = 17;
            dgvContactList.RowHeaderMouseClick += dgvContactList_RowHeaderMouseClick;
            // 
            // txtboxSearch
            // 
            txtboxSearch.Location = new Point(421, 133);
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.Size = new Size(468, 23);
            txtboxSearch.TabIndex = 19;
            txtboxSearch.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1182, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(912, 133);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 586);
            Controls.Add(btnSearch);
            Controls.Add(pictureBox2);
            Controls.Add(txtboxSearch);
            Controls.Add(dgvContactList);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblGender);
            Controls.Add(cmbGender);
            Controls.Add(txtboxAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtboxFirstName);
            Controls.Add(lblfirstname);
            Controls.Add(txtboxLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtBoxContactNumber);
            Controls.Add(lblContactNo);
            Controls.Add(txtboxContactID);
            Controls.Add(lblContactID);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvContactList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblContactID;
        private TextBox txtboxContactID;
        private TextBox txtBoxContactNumber;
        private Label lblContactNo;
        private TextBox txtboxLastName;
        private Label lblLastName;
        private TextBox txtboxFirstName;
        private Label lblfirstname;
        private TextBox txtboxAddress;
        private Label lblAddress;
        private ComboBox cmbGender;
        private Label lblGender;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvContactList;
        private TextBox txtboxSearch;
        private PictureBox pictureBox2;
        private Button btnSearch;
    }
}
