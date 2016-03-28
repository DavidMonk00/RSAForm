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
    public partial class DecryptForm : Form
    {
        string filepath;
        public DecryptForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
                textBox1.Text = filepath;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filepath = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            RSA.Decrypt dec = new RSA.Decrypt(filepath);
            progressBar1.PerformStep();
            dec.DecryptFile();
            progressBar1.PerformStep();
            button1.Visible = true;
        }
    }
}
