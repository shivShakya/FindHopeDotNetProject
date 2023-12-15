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
            this.components = new System.ComponentModel.Container();
            this.Fom3Title = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.goBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOutAdmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.volPanel1 = new System.Windows.Forms.Panel();
            this.postPanel1 = new System.Windows.Forms.Panel();
            this.createPostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.findHopeDataSet = new shivamProject.findHopeDataSet();
            this.createPostTableAdapter = new shivamProject.findHopeDataSetTableAdapters.CreatePostTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.findHopeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aadharNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volunteerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.findHopeDataSet1 = new shivamProject.findHopeDataSet1();
            this.volunteerDetailsTableAdapter = new shivamProject.findHopeDataSet1TableAdapters.volunteerDetailsTableAdapter();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.volPanel1.SuspendLayout();
            this.postPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createPostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findHopeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findHopeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteerDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findHopeDataSet1)).BeginInit();
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.volPanel1);
            this.flowLayoutPanel1.Controls.Add(this.postPanel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(215, 75);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(550, 329);
            this.flowLayoutPanel1.TabIndex = 3;
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
            // postPanel1
            // 
            this.postPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.postPanel1.Controls.Add(this.dataGridView2);
            this.postPanel1.Location = new System.Drawing.Point(3, 331);
            this.postPanel1.Name = "postPanel1";
            this.postPanel1.Size = new System.Drawing.Size(518, 322);
            this.postPanel1.TabIndex = 0;
            // 
            // createPostBindingSource
            // 
            this.createPostBindingSource.DataMember = "CreatePost";
            this.createPostBindingSource.DataSource = this.findHopeDataSet;
            // 
            // findHopeDataSet
            // 
            this.findHopeDataSet.DataSetName = "findHopeDataSet";
            this.findHopeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // createPostTableAdapter
            // 
            this.createPostTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.aadharNoDataGridViewTextBoxColumn,
            this.occupationDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn,
            this.motivationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.volunteerDetailsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // findHopeDataSetBindingSource
            // 
            this.findHopeDataSetBindingSource.DataSource = this.findHopeDataSet;
            this.findHopeDataSetBindingSource.Position = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.imageDataGridViewTextBoxColumn1,
            this.messageDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.createPostBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(518, 322);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // imageDataGridViewTextBoxColumn1
            // 
            this.imageDataGridViewTextBoxColumn1.DataPropertyName = "image";
            this.imageDataGridViewTextBoxColumn1.HeaderText = "image";
            this.imageDataGridViewTextBoxColumn1.Name = "imageDataGridViewTextBoxColumn1";
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "message";
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // aadharNoDataGridViewTextBoxColumn
            // 
            this.aadharNoDataGridViewTextBoxColumn.DataPropertyName = "aadharNo";
            this.aadharNoDataGridViewTextBoxColumn.HeaderText = "aadharNo";
            this.aadharNoDataGridViewTextBoxColumn.Name = "aadharNoDataGridViewTextBoxColumn";
            // 
            // occupationDataGridViewTextBoxColumn
            // 
            this.occupationDataGridViewTextBoxColumn.DataPropertyName = "occupation";
            this.occupationDataGridViewTextBoxColumn.HeaderText = "occupation";
            this.occupationDataGridViewTextBoxColumn.Name = "occupationDataGridViewTextBoxColumn";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "image";
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            // 
            // motivationDataGridViewTextBoxColumn
            // 
            this.motivationDataGridViewTextBoxColumn.DataPropertyName = "motivation";
            this.motivationDataGridViewTextBoxColumn.HeaderText = "motivation";
            this.motivationDataGridViewTextBoxColumn.Name = "motivationDataGridViewTextBoxColumn";
            // 
            // volunteerDetailsBindingSource
            // 
            this.volunteerDetailsBindingSource.DataMember = "volunteerDetails";
            this.volunteerDetailsBindingSource.DataSource = this.findHopeDataSet1;
            // 
            // findHopeDataSet1
            // 
            this.findHopeDataSet1.DataSetName = "findHopeDataSet1";
            this.findHopeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // volunteerDetailsTableAdapter
            // 
            this.volunteerDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.Fom3Title);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.volPanel1.ResumeLayout(false);
            this.postPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.createPostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findHopeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findHopeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteerDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findHopeDataSet1)).EndInit();
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
        private findHopeDataSet findHopeDataSet;
        private System.Windows.Forms.BindingSource createPostBindingSource;
        private findHopeDataSetTableAdapters.CreatePostTableAdapter createPostTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource findHopeDataSetBindingSource;
        private findHopeDataSet1 findHopeDataSet1;
        private System.Windows.Forms.BindingSource volunteerDetailsBindingSource;
        private findHopeDataSet1TableAdapters.volunteerDetailsTableAdapter volunteerDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aadharNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
    }
}