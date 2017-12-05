using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TellMe
{
    public partial class FormTellMe : Form
    {

        private AES265 aes256;

        public FormTellMe()
        {
            InitializeComponent();
        }

        private void btnApplyKey_Click(object sender, EventArgs e)
        {
            this.aes256 = new AES265(maskedTextBoxKey.Text);
            maskedTextBoxKey.Text = "";
        }

        private void btnToEs_Click(object sender, EventArgs e)
        {
            // textBoxEs.Text = textBoxMe.Text;
            textBoxEs.Text = this.aes256.Encrypt(textBoxMe.Text);
            textBoxMe.Text = "";
        }

        private void btnToMe_Click(object sender, EventArgs e)
        {
            
            // textBoxMe.Text = textBoxEs.Text;
            textBoxMe.Text = this.aes256.Decrypt(textBoxEs.Text);
            textBoxEs.Text = "";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            textBoxEs.Text = "";
            textBoxMe.Text = "";
        }
    }
}
