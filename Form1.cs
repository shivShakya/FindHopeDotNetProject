using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void volButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            this.Hide();
        }

        private void adminUse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
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
