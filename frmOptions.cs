using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Encryptor
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            cmbFormat.Text = Properties.Settings.Default.Format;
            cmbMethod.Text = Properties.Settings.Default.Method;
            numericUpDownSplitLines.Value = Properties.Settings.Default.SplitLine;
            numericUpDownCaesar.Value = Properties.Settings.Default.Caesar_Shift;
            tbXOR.Text = Properties.Settings.Default.XOR_Key;
            tbIV.Text = Properties.Settings.Default.AES_IV;
            tbKey.Text = Properties.Settings.Default.AES_Key;
            nudTabs.Value = Properties.Settings.Default.Tabs;
            chkBase64SplitLines.Checked = Properties.Settings.Default.Split_base64;
            tbXanaxXOR1.Text = Properties.Settings.Default.Xanax_XOR1;
            tbXanaxXOR2.Text = Properties.Settings.Default.Xanax_XOR2;
            nudXanaxAdd1.Value = Properties.Settings.Default.Xanax_Add1;
            nudXanaxAdd2.Value = Properties.Settings.Default.Xanax_Add2;
            nudInsertionFreq.Value = Properties.Settings.Default.Insertion_Freq;
            tbInsertionString.Text = Properties.Settings.Default.Insertion_String;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Format = cmbFormat.Text.ToString();
            Properties.Settings.Default.Method = cmbMethod.Text.ToString();
            Properties.Settings.Default.SplitLine = numericUpDownSplitLines.Value;
            Properties.Settings.Default.Caesar_Shift = numericUpDownCaesar.Value;
            Properties.Settings.Default.XOR_Key = tbXOR.Text;
            Properties.Settings.Default.AES_IV = tbIV.Text;
            Properties.Settings.Default.AES_Key = tbKey.Text;
            Properties.Settings.Default.Tabs = nudTabs.Value;
            Properties.Settings.Default.Split_base64 = chkBase64SplitLines.Checked;
            Properties.Settings.Default.Xanax_XOR1 = tbXanaxXOR1.Text;
            Properties.Settings.Default.Xanax_XOR2= tbXanaxXOR2.Text;
            Properties.Settings.Default.Xanax_Add1 = nudXanaxAdd1.Value ;
            Properties.Settings.Default.Xanax_Add2 = nudXanaxAdd2.Value;
            Properties.Settings.Default.Insertion_Freq = nudInsertionFreq.Value;
            Properties.Settings.Default.Insertion_String = tbInsertionString.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            using (Aes aesAlg = Aes.Create())
            {
                tbKey.Text = System.Text.Encoding.ASCII.GetString(aesAlg.Key, 0, aesAlg.Key.Length); //16 bytes 
                tbIV.Text = System.Text.Encoding.ASCII.GetString(aesAlg.IV, 0, aesAlg.IV.Length); //32 bytes
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/su1s/encryptor");
        }

        private void btnGenerateInsertionString_Click(object sender, EventArgs e)
        {
            using (Aes aesAlg = Aes.Create())
            {
                tbInsertionString.Text = System.Text.Encoding.ASCII.GetString(aesAlg.IV, 0, aesAlg.IV.Length); //32 bytes
            }
        }
    }
}
