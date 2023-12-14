namespace shivamProject
{
    partial class Form1
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
            this.volButton = new System.Windows.Forms.Button();
            this.projName = new System.Windows.Forms.Label();
            this.typingEffect = new System.Windows.Forms.Label();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.adharLabel = new System.Windows.Forms.Label();
            this.adharBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.adminUse = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // volButton
            // 
            this.volButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.volButton.Location = new System.Drawing.Point(69, 388);
            this.volButton.Name = "volButton";
            this.volButton.Size = new System.Drawing.Size(128, 38);
            this.volButton.TabIndex = 0;
            this.volButton.Text = "Volunteer";
            this.volButton.UseVisualStyleBackColor = true;
            this.volButton.Click += new System.EventHandler(this.volButton_Click);
            // 
            // projName
            // 
            this.projName.AutoSize = true;
            this.projName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.projName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projName.ForeColor = System.Drawing.SystemColors.Control;
            this.projName.Location = new System.Drawing.Point(12, 14);
            this.projName.Name = "projName";
            this.projName.Padding = new System.Windows.Forms.Padding(4);
            this.projName.Size = new System.Drawing.Size(121, 33);
            this.projName.TabIndex = 2;
            this.projName.Text = "FindHope";
            this.projName.Click += new System.EventHandler(this.projName_Click);
            // 
            // typingEffect
            // 
            this.typingEffect.AutoSize = true;
            this.typingEffect.BackColor = System.Drawing.SystemColors.HotTrack;
            this.typingEffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typingEffect.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.typingEffect.Location = new System.Drawing.Point(12, 117);
            this.typingEffect.Name = "typingEffect";
            this.typingEffect.Size = new System.Drawing.Size(0, 20);
            this.typingEffect.TabIndex = 3;
            this.typingEffect.Click += new System.EventHandler(this.typingEffect_Click);
            // 
            // LogInBtn
            // 
            this.LogInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LogInBtn.Location = new System.Drawing.Point(519, 242);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(77, 27);
            this.LogInBtn.TabIndex = 4;
            this.LogInBtn.Text = "LogIn";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // adharLabel
            // 
            this.adharLabel.AutoSize = true;
            this.adharLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.adharLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.adharLabel.Location = new System.Drawing.Point(525, 117);
            this.adharLabel.Name = "adharLabel";
            this.adharLabel.Size = new System.Drawing.Size(81, 13);
            this.adharLabel.TabIndex = 5;
            this.adharLabel.Text = "Aadhar Number";
            // 
            // adharBox
            // 
            this.adharBox.Location = new System.Drawing.Point(519, 133);
            this.adharBox.Name = "adharBox";
            this.adharBox.Size = new System.Drawing.Size(180, 20);
            this.adharBox.TabIndex = 6;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.passwordLabel.Location = new System.Drawing.Point(525, 185);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(519, 201);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(180, 20);
            this.passwordBox.TabIndex = 8;
            // 
            // adminUse
            // 
            this.adminUse.AutoSize = true;
            this.adminUse.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.adminUse.Location = new System.Drawing.Point(693, 403);
            this.adminUse.Name = "adminUse";
            this.adminUse.Size = new System.Drawing.Size(95, 13);
            this.adminUse.TabIndex = 9;
            this.adminUse.TabStop = true;
            this.adminUse.Text = "For admin use only";
            this.adminUse.VisitedLinkColor = System.Drawing.Color.Blue;
            this.adminUse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.adminUse_LinkClicked);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(203, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Create Post";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adminUse);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.adharBox);
            this.Controls.Add(this.adharLabel);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.typingEffect);
            this.Controls.Add(this.projName);
            this.Controls.Add(this.volButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button volButton;
        public System.Windows.Forms.Label projName;
        private System.Windows.Forms.Label typingEffect;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Label adharLabel;
        private System.Windows.Forms.TextBox adharBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.LinkLabel adminUse;
        private System.Windows.Forms.Button button1;
    }
}

