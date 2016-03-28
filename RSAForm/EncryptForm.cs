using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAForm
{
    public partial class EncryptForm : Form
    {
        string filepath;
        string key_file;
        public EncryptForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            key_file = comboBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filepath = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            RSA.Encrypt enc = new RSA.Encrypt(key_file, filepath);
            progressBar1.PerformStep();
            enc.EncryptFile();
            progressBar1.PerformStep();
            button3.Visible = true;
        }
    }
}
