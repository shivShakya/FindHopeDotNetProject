using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shivamProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartTypingAnim("Discovet the power of compassion by volunteering \nwith FindHope. Your involvement can bring comfort  \nto familes searching for their loved ones. Be  a part \nof something truely impactful . Together we can  \nmake a postiving differece . Join the community !  \n");
        }


        private void projName_Click(object sender, EventArgs e)
        {

        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-UR174K2;Initial Catalog=FindHope;Integrated Security=True;";
            if (adharBox.Text != "" && passwordBox.Text != "")
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    try
                    {

                        string query = "SELECT COUNT(*) FROM VolunteerDetails WHERE aadharNo = @Aadhar AND password = @Password";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {

                            cmd.Parameters.AddWithValue("@Aadhar", adharBox.Text);
                            cmd.Parameters.AddWithValue("@Password", passwordBox.Text);

                            int count = (int)cmd.ExecuteScalar();

                            if (count > 0)
                            {

                                MessageBox.Show("Login successful!");
                                Form4 form4 = new Form4();
                                form4.Show();
                                this.Hide();
                            }
                            else
                            {

                                MessageBox.Show("Invalid credential Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to insert message" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
 
                MessageBox.Show("Please enter Aadhar and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void volButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            this.Hide();
        }

        private void adminUse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string userInput = Microsoft.VisualBasic.Interaction.InputBox("Enter some Input :", "Input Box", "");

            if (userInput == "admin4100")
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid input. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void typingEffect_Click(object sender, EventArgs e)
        {
           
        }

        private void StartTypingAnim(string text)
        {
            Thread typingThread = new Thread(() => { 
                  foreach(char c in text)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        typingEffect.Text += c;
                    });

                    Thread.Sleep(50);
                }
            });
            typingThread.Start();
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
