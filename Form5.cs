using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace shivamProject
{
    public partial class Form5 : Form
    {
        private string imageFolderPath = "Images";


        private string fileName;
        private string destinationPath;

        public Form5()
        {
            InitializeComponent();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    fileName = Path.GetFileName(selectedImagePath);
                    destinationPath = Path.Combine(imageFolderPath, fileName); 

                    try
                    {
                        using (FileStream fileStream = new FileStream(selectedImagePath, FileMode.Open, FileAccess.Read))
                        {
                            pictureBox1.Image = Image.FromStream(fileStream);
                        }
                        File.Copy(selectedImagePath, destinationPath, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error copying or loading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text) && destinationPath != "")
            {
                string connectionString = "Data Source=DESKTOP-UR174K2;Initial Catalog=FindHope;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO CreatePost (image, message) VALUES (@image, @message)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@image", destinationPath);
                        command.Parameters.AddWithValue("@message", richTextBox1.Text);
                        //command.Parameters.AddWithValue("@long",longitude);
                        //command.Parameters.AddWithValue("@lat",latitude);
                        try
                        {
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Message inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                richTextBox1.Clear();
                                destinationPath = "";
                            }
                            else
                            {
                                MessageBox.Show("Failed to insert message", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }catch(Exception ex)
                        {
                            MessageBox.Show("Failed to insert message" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please write your message", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
