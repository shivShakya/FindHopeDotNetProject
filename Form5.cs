using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shivamProject
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private string imageFolderPath = "Images";
        private void upload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(selectedImagePath);

                    // Ensure the destination directory exists
                    Directory.CreateDirectory(imageFolderPath);

                    string destinationPath = Path.Combine(imageFolderPath, fileName);

                    try
                    {
                        // Use FileStream to load the image and then set it to pictureBox1
                        using (FileStream fileStream = new FileStream(selectedImagePath, FileMode.Open, FileAccess.Read))
                        {
                            pictureBox1.Image = Image.FromStream(fileStream);
                        }

                        // Now you can copy the file without interference
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
    }
}
