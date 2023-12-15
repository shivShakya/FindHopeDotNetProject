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

namespace shivamProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private string imageFolderPath = "Images";

        private string fileName;
        private string destinationPath;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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

                   
                    Directory.CreateDirectory(imageFolderPath);

                    destinationPath = Path.Combine(imageFolderPath, fileName);

                    try
                    {
                     
                        using (FileStream fileStream = new FileStream(selectedImagePath, FileMode.Open, FileAccess.Read))
                        {
                            pictureBox2.Image = Image.FromStream(fileStream);
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

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            String gender = gendBox.Text;

            if (!string.IsNullOrEmpty(nameBox.Text) && !string.IsNullOrEmpty(passwordBox.Text) && !string.IsNullOrEmpty(adharBox.Text) && !string.IsNullOrEmpty(EmailBox.Text) && destinationPath != "" )
            {
                string connectionString = "Data Source=DESKTOP-UR174K2;Initial Catalog=FindHope;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO VolunteerDetails (name , email , password ,aadharNo ,occupation, dob,gender,address , image , motivation  ) VALUES (@name , @email , @password , @aadharNo , @occupation , @dob , @gender, @address , @image , @message )";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@name", nameBox.Text);
                        command.Parameters.AddWithValue("@email", EmailBox.Text);
                        command.Parameters.AddWithValue("@password", passwordBox.Text);
                        command.Parameters.AddWithValue("@aadharNo", adharBox.Text);
                        command.Parameters.AddWithValue("@occupation",occupationBox.Text);
                        command.Parameters.AddWithValue("@dob", dateTimePicker2.Text);
                        command.Parameters.AddWithValue("@gender", gender[0]);
                        command.Parameters.AddWithValue("@address", addrBox.Text);
                        command.Parameters.AddWithValue("@image", destinationPath);
                        command.Parameters.AddWithValue("@message", motivationBox.Text);
                        try
                        {
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Message inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                nameBox.Clear();
                                EmailBox.Clear();
                                passwordBox.Clear();
                                adharBox.Clear();
                                occupationBox.Clear();
                                addrBox.Clear();
                                motivationBox.Clear();

                                destinationPath = "";

                                Form1 form1 = new Form1();
                                form1.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Failed to insert form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed to insert form" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill the form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
