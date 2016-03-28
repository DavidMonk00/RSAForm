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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void buttonKeyGen_Click(object sender, EventArgs e)
        {
            KeyGeneration kg = new KeyGeneration();
            kg.Show();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            EncryptForm encf = new EncryptForm();
            encf.Show();
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            DecryptForm decf = new DecryptForm();
            decf.Show();
        }
    }
}
