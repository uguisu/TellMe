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
            if (maskedTextBoxKey.Text.Length < 8)
            {
                // key not long enought
                MessageBox.Show("Key should at least 8 characters", "Wow", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.aes256 = new AES265(maskedTextBoxKey.Text);
                // Clean key
                maskedTextBoxKey.Text = "";
                // Enable buttons
                controllButton(true);
            }
        }

        private void btnToEs_Click(object sender, EventArgs e)
        {
            if (!"".Equals(textBoxMe.Text.Trim()))
            {
                textBoxEs.Text = this.aes256.Encrypt(textBoxMe.Text);
                textBoxMe.Text = "";
            }
        }

        private void btnToMe_Click(object sender, EventArgs e)
        {
            if (!"".Equals(textBoxEs.Text.Trim()))
            {
                textBoxMe.Text = this.aes256.Decrypt(textBoxEs.Text);
                textBoxEs.Text = "";
            }
        }

        /// <summary>
        /// Clean all textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClean_Click(object sender, EventArgs e)
        {
            textBoxEs.Text = "";
            textBoxMe.Text = "";
        }

        private void FormTellMe_Load(object sender, EventArgs e)
        {
            // Disable transfer button
            controllButton(false);
        }

        /// <summary>
        /// Controll button
        /// </summary>
        /// <param name="isEnabled"></param>
        private void controllButton(bool isEnabled)
        {
            btnToMe.Enabled = isEnabled;
            btnToEs.Enabled = isEnabled;
        }

    }
}
