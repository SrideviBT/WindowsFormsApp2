using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
          var response=await  RequestHelper.GetALL();
           
            richTextBox1.Text =RequestHelper.BeautifyJson(response);
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            var response = await RequestHelper.Post( textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            richTextBox1.Text = RequestHelper.BeautifyJson(response);
            
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            var response = await RequestHelper.Get(textBox1.Text);
            richTextBox1.Text = RequestHelper.BeautifyJson(response);
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == null || textBox2.Text == "")
            {
                MessageBox.Show("Please enter some data to update");
            }
            else
            {
                var response = await RequestHelper.Put(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                richTextBox1.Text = RequestHelper.BeautifyJson(response);
             }
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == null || textBox2.Text == "")
            {
                MessageBox.Show("Please enter an ID to delete");
            }
            else
            {
                var response = await RequestHelper.Delete(textBox2.Text);
                MessageBox.Show("Deleted");
            }
        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

