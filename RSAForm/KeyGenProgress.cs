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
    public partial class KeyGenProgress : Form
    {
        int strength;
        public KeyGenProgress(int strength)
        {
            InitializeComponent();
            progressBar1.PerformStep();
            RSA.Key k = new RSA.Key(strength);
            progressBar1.PerformStep();
            label1.Text = "Generating first prime...";
            k.pGen();
            progressBar1.PerformStep();
            label1.Text = "Generating second prime...";
            k.qGen();
            progressBar1.PerformStep();
            label1.Text = "Creating public and private keys...";
            k.nGen();
            k.dGen();
            k.PublicKeyGen();
            k.PrivateKeyGen();
            /*progressBar1.PerformStep();
            label1.Text = "Saving keys...";
            k.SaveKey();
            progressBar1.PerformStep();
            label1.Text = "Keys created.";*/
        }
    }

}
