using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shivamProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            volPanel1.Visible = true;
            postPanel1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            volPanel1.Visible = false;
            postPanel1.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'findHopeDataSet1.volunteerDetails' table. You can move, or remove it, as needed.
            this.volunteerDetailsTableAdapter.Fill(this.findHopeDataSet1.volunteerDetails);
            this.createPostTableAdapter.Fill(this.findHopeDataSet.CreatePost);
            dataGridView1.DataSource = this.findHopeDataSet.CreatePost;
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.volunteerDetailsTableAdapter.FillBy(this.findHopeDataSet1.volunteerDetails);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
