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
            KeyGenProgress prog = new KeyGenProgress(trackBar1.Value);
            prog.Show();
        }
    }
}
