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
        string XORKeyBase64 = ""; 
        string AESIVBase64 = "";
        string AESKeyBase64 = "";
        string InsertionKeyBase64 = "";

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
            XORKeyBase64 = Properties.Settings.Default.XOR_Key;
            AESIVBase64 = Properties.Settings.Default.AES_IV;
            AESKeyBase64 = Properties.Settings.Default.AES_Key;
            nudTabs.Value = Properties.Settings.Default.Tabs;
            chkBase64SplitLines.Checked = Properties.Settings.Default.Split_base64;
            tbXanaxXOR1.Text = Properties.Settings.Default.Xanax_XOR1;
            tbXanaxXOR2.Text = Properties.Settings.Default.Xanax_XOR2;
            nudXanaxAdd1.Value = Properties.Settings.Default.Xanax_Add1;
            nudXanaxAdd2.Value = Properties.Settings.Default.Xanax_Add2;
            nudInsertionFreq.Value = Properties.Settings.Default.Insertion_Freq;
            InsertionKeyBase64 = Properties.Settings.Default.Insertion_String;
            // Update textboxes from base64 strings
            updateTextBoxes();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Format = cmbFormat.Text.ToString();
            Properties.Settings.Default.Method = cmbMethod.Text.ToString();
            Properties.Settings.Default.SplitLine = numericUpDownSplitLines.Value;
            Properties.Settings.Default.Caesar_Shift = numericUpDownCaesar.Value;
            Properties.Settings.Default.XOR_Key = XORKeyBase64;
            Properties.Settings.Default.AES_IV = AESIVBase64;
            Properties.Settings.Default.AES_Key = AESKeyBase64;
            Properties.Settings.Default.Tabs = nudTabs.Value;
            Properties.Settings.Default.Split_base64 = chkBase64SplitLines.Checked;
            Properties.Settings.Default.Xanax_XOR1 = tbXanaxXOR1.Text;
            Properties.Settings.Default.Xanax_XOR2= tbXanaxXOR2.Text;
            Properties.Settings.Default.Xanax_Add1 = nudXanaxAdd1.Value ;
            Properties.Settings.Default.Xanax_Add2 = nudXanaxAdd2.Value;
            Properties.Settings.Default.Insertion_Freq = nudInsertionFreq.Value;
            Properties.Settings.Default.Insertion_String = InsertionKeyBase64;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            using (Aes aesAlg = Aes.Create())
            {
                AESKeyBase64 = Convert.ToBase64String(aesAlg.Key);
                AESIVBase64 = Convert.ToBase64String(aesAlg.IV);
                updateTextBoxes();
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
                InsertionKeyBase64 = Convert.ToBase64String(aesAlg.Key);
                updateTextBoxes();
            }
        }

        private void tbIV_Leave(object sender, EventArgs e)
        {
            AESIVBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(tbIV.Text));
        }

        private void tbKey_Leave(object sender, EventArgs e)
        {
            AESKeyBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(tbKey.Text));
        }

        private void updateTextBoxes()
        {
            // XOR
            byte[] XORByteArray = System.Convert.FromBase64String(XORKeyBase64);
            tbXOR.Text = System.Text.Encoding.UTF8.GetString(XORByteArray, 0, XORByteArray.Length);
            // AES 
            byte[] IVByteArray = System.Convert.FromBase64String(AESIVBase64);
            tbIV.Text = System.Text.Encoding.UTF8.GetString(IVByteArray, 0, IVByteArray.Length);
            byte[] KeyByteArray = System.Convert.FromBase64String(AESKeyBase64);
            tbKey.Text = System.Text.Encoding.UTF8.GetString(KeyByteArray, 0, KeyByteArray.Length);
            // Insertion 
            byte[] InsertionByteArray = System.Convert.FromBase64String(InsertionKeyBase64);
            tbInsertionString.Text = System.Text.Encoding.UTF8.GetString(InsertionByteArray, 0, InsertionByteArray.Length);
            this.Refresh();
        }

        private void tbXOR_Leave(object sender, EventArgs e)
        {
            XORKeyBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(tbXOR.Text));
        }


        private void btnGenerateXOR_Click(object sender, EventArgs e)
        {
            using (Aes aesAlg = Aes.Create())
            {
                XORKeyBase64 = Convert.ToBase64String(aesAlg.Key);
                updateTextBoxes();
            }
        }

        private void tbInsertionString_Leave(object sender, EventArgs e)
        {
            InsertionKeyBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(tbInsertionString.Text));
        }
    }
}
