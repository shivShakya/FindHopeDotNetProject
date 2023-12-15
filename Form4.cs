using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shivamProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void postInfo_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            List<string> data = GetDataFromDatabase();

            // Create a PictureBox
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(100, 100);
            pictureBox.Location = new Point(10, 10); 

            // Create a Label
            Label label = new Label();
            label.Text = data.Count > 0 ? data[0] : "No data";
            label.AutoSize = true;
            label.Location = new Point(120, 10);

            // Create a Button
            Button button = new Button();
            button.Text = "Inform";
            button.Size = new Size(80, 30);
            button.Location = new Point(10, 120);
            button.Click += (btnSender, btnEvent) =>
            {
                // Handle the button click event
                MessageBox.Show("Inform Button Clicked");
            };

            // Add controls to the panel
            panel5.Controls.Add(pictureBox);
            panel5.Controls.Add(label);
            panel5.Controls.Add(button);
        }

        private List<string> GetDataFromDatabase()
        {
            string connectionString = "Data Source=DESKTOP-UR174K2;Initial Catalog=FindHope;Integrated Security=True;";
            List<string> data = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM CreatePost";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value1 = reader["image"].ToString();
                            string value2 = reader["message"].ToString();
                            data.Add(value1);
                            data.Add(value2);
                        }
                    }
                }
            }

            return data;
        }
    }
}
