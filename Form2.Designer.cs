namespace shivamProject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.upload = new System.Windows.Forms.Button();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.AadharNo = new System.Windows.Forms.Label();
            this.adharBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.ocup = new System.Windows.Forms.Label();
            this.occupationBox = new System.Windows.Forms.TextBox();
            this.DOB = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.gendBox = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addrBox = new System.Windows.Forms.RichTextBox();
            this.MotivationLab = new System.Windows.Forms.Label();
            this.motivationBox = new System.Windows.Forms.RichTextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 215);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(520, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Create Your Account";
            // 
            // upload
            // 
            this.upload.BackColor = System.Drawing.SystemColors.HotTrack;
            this.upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.upload.Location = new System.Drawing.Point(37, 337);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(167, 33);
            this.upload.TabIndex = 2;
            this.upload.Text = "Upload ";
            this.upload.UseVisualStyleBackColor = false;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.nameLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameLabel1.Location = new System.Drawing.Point(280, 92);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(35, 13);
            this.nameLabel1.TabIndex = 3;
            this.nameLabel1.Text = "Name";
            this.nameLabel1.Click += new System.EventHandler(this.label9_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(283, 108);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(147, 20);
            this.nameBox.TabIndex = 4;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmailLabel.Location = new System.Drawing.Point(280, 131);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "Email";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(283, 147);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(147, 20);
            this.EmailBox.TabIndex = 6;
            // 
            // AadharNo
            // 
            this.AadharNo.AutoSize = true;
            this.AadharNo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AadharNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AadharNo.Location = new System.Drawing.Point(280, 170);
            this.AadharNo.Name = "AadharNo";
            this.AadharNo.Size = new System.Drawing.Size(81, 13);
            this.AadharNo.TabIndex = 7;
            this.AadharNo.Text = "Aadhar Number";
            // 
            // adharBox
            // 
            this.adharBox.Location = new System.Drawing.Point(283, 186);
            this.adharBox.Name = "adharBox";
            this.adharBox.Size = new System.Drawing.Size(147, 20);
            this.adharBox.TabIndex = 8;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordLabel.Location = new System.Drawing.Point(280, 209);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(283, 225);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(147, 20);
            this.passwordBox.TabIndex = 10;
            // 
            // ocup
            // 
            this.ocup.AutoSize = true;
            this.ocup.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ocup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ocup.Location = new System.Drawing.Point(497, 92);
            this.ocup.Name = "ocup";
            this.ocup.Size = new System.Drawing.Size(62, 13);
            this.ocup.TabIndex = 11;
            this.ocup.Text = "Occupation";
            // 
            // occupationBox
            // 
            this.occupationBox.Location = new System.Drawing.Point(500, 108);
            this.occupationBox.Name = "occupationBox";
            this.occupationBox.Size = new System.Drawing.Size(147, 20);
            this.occupationBox.TabIndex = 12;
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DOB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DOB.Location = new System.Drawing.Point(497, 131);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(66, 13);
            this.DOB.TabIndex = 13;
            this.DOB.Text = "Date of Birth";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(500, 147);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // gendBox
            // 
            this.gendBox.AutoSize = true;
            this.gendBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.gendBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gendBox.Location = new System.Drawing.Point(497, 170);
            this.gendBox.Name = "gendBox";
            this.gendBox.Size = new System.Drawing.Size(42, 13);
            this.gendBox.TabIndex = 15;
            this.gendBox.Text = "Gender";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(500, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(497, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Address";
            // 
            // addrBox
            // 
            this.addrBox.Location = new System.Drawing.Point(500, 225);
            this.addrBox.Name = "addrBox";
            this.addrBox.Size = new System.Drawing.Size(147, 20);
            this.addrBox.TabIndex = 18;
            this.addrBox.Text = "";
            // 
            // MotivationLab
            // 
            this.MotivationLab.AutoSize = true;
            this.MotivationLab.BackColor = System.Drawing.SystemColors.HotTrack;
            this.MotivationLab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MotivationLab.Location = new System.Drawing.Point(280, 248);
            this.MotivationLab.Name = "MotivationLab";
            this.MotivationLab.Size = new System.Drawing.Size(56, 13);
            this.MotivationLab.TabIndex = 19;
            this.MotivationLab.Text = "Motivation";
            // 
            // motivationBox
            // 
            this.motivationBox.Location = new System.Drawing.Point(283, 264);
            this.motivationBox.Name = "motivationBox";
            this.motivationBox.Size = new System.Drawing.Size(364, 43);
            this.motivationBox.TabIndex = 20;
            this.motivationBox.Text = "";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubmitBtn.Location = new System.Drawing.Point(480, 326);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(167, 33);
            this.SubmitBtn.TabIndex = 21;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(24, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 33);
            this.button2.TabIndex = 22;
            this.button2.Text = "go back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(751, 499);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.motivationBox);
            this.Controls.Add(this.MotivationLab);
            this.Controls.Add(this.addrBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gendBox);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.occupationBox);
            this.Controls.Add(this.ocup);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.adharBox);
            this.Controls.Add(this.AadharNo);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.Label backlink;
        private System.Windows.Forms.LinkLabel backLink2;
        private System.Windows.Forms.Label nmLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox eml;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adhr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ocp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox addr;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox genderbox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label AadharNo;
        private System.Windows.Forms.TextBox adharBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label ocup;
        private System.Windows.Forms.TextBox occupationBox;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label gendBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox addrBox;
        private System.Windows.Forms.Label MotivationLab;
        private System.Windows.Forms.RichTextBox motivationBox;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button button2;
    }
}