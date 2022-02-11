using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES_Encrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbUserString.Text = string.Empty;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (tbUserString.Text.Equals(""))
            {
                MessageBox.Show("Please enter text to encrypt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tbEncryption.Text = Encryption.Encrypt(tbUserString.Text);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (tbEncryption.Text.Equals(""))
            {
                MessageBox.Show("There is nothing to decrypt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tbEncryption.Text = Encryption.Decrypt();
        }
    }
}
