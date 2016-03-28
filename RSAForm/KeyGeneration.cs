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
    public partial class KeyGeneration : Form
    {
        bool close = false;
        public KeyGeneration()
        {
            InitializeComponent();
        }

        private void KeyGeneration_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = (2*trackBar1.Value).ToString();
        }

        private void buttonGenerateKey_Click(object sender, EventArgs e)
        {
            if (!close)
            {
                int strength = trackBar1.Value;
                progressBar1.Visible = true;
                label4.Visible = true;
                progressBar1.PerformStep();
                RSA.Key k = new RSA.Key(strength);
                progressBar1.PerformStep();
                label4.Text = "Generating first prime...";
                k.pGen();
                progressBar1.PerformStep();
                label4.Text = "Generating second prime...";
                k.qGen();
                progressBar1.PerformStep();
                label4.Text = "Creating public and private keys...";
                k.nGen();
                k.dGen();
                k.PublicKeyGen();
                k.PrivateKeyGen();
                progressBar1.PerformStep();
                label4.Text = "Saving keys...";
                k.SaveKey();
                progressBar1.PerformStep();
                label4.Text = "Key created.";
                buttonGenerateKey.Text = "Close";
                close = true;
            }
            else
            {
                this.Close();
            }
            
        }
    }
}
