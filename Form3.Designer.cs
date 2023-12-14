namespace shivamProject
{
    partial class Form3
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
            this.Fom3Title = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.goBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogOutAdmin = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.postPanel1 = new System.Windows.Forms.Panel();
            this.volPanel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.volPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Fom3Title
            // 
            this.Fom3Title.AutoSize = true;
            this.Fom3Title.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Fom3Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fom3Title.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Fom3Title.Location = new System.Drawing.Point(652, 25);
            this.Fom3Title.Name = "Fom3Title";
            this.Fom3Title.Size = new System.Drawing.Size(146, 25);
            this.Fom3Title.TabIndex = 0;
            this.Fom3Title.Text = "Admin Portal";
            // 
            // goBack
            // 
            this.goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBack.ForeColor = System.Drawing.Color.SteelBlue;
            this.goBack.Location = new System.Drawing.Point(12, 12);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(84, 26);
            this.goBack.TabIndex = 1;
            this.goBack.Text = "go back";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.LogOutAdmin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 369);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Volunteer Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Post Details";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LogOutAdmin
            // 
            this.LogOutAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutAdmin.Location = new System.Drawing.Point(3, 339);
            this.LogOutAdmin.Name = "LogOutAdmin";
            this.LogOutAdmin.Size = new System.Drawing.Size(170, 27);
            this.LogOutAdmin.TabIndex = 2;
            this.LogOutAdmin.Text = "Log Out";
            this.LogOutAdmin.UseVisualStyleBackColor = true;
            this.LogOutAdmin.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.volPanel1);
            this.flowLayoutPanel1.Controls.Add(this.postPanel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(215, 75);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(550, 347);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // postPanel1
            // 
            this.postPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.postPanel1.Location = new System.Drawing.Point(3, 331);
            this.postPanel1.Name = "postPanel1";
            this.postPanel1.Size = new System.Drawing.Size(518, 322);
            this.postPanel1.TabIndex = 0;
            // 
            // volPanel1
            // 
            this.volPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.volPanel1.Controls.Add(this.dataGridView1);
            this.volPanel1.Location = new System.Drawing.Point(3, 3);
            this.volPanel1.Name = "volPanel1";
            this.volPanel1.Size = new System.Drawing.Size(518, 322);
            this.volPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.Fom3Title);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.volPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Fom3Title;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LogOutAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel volPanel1;
        private System.Windows.Forms.Panel postPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}