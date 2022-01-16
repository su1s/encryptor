using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security;
using System.IO;

namespace Encryptor
{
    public partial class frmMain : Form
    {
        public byte[] RawShellcode;
        public byte[] EncodedShellcode;
        public byte[] TempShellcode;
        public string Display_Format;
        public string Encoding_Method;
        public string Encoding_Type;

        public frmMain()
        {
            InitializeComponent();
        }

        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmOptions formOptions = new frmOptions();
            if (formOptions.ShowDialog() == DialogResult.OK);
            {
                if (RawShellcode is not null)
                {
                    this.EncodeShellcode();
                }
                menuStrip1.Focus();
            }
         }

        private void loadShellcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    RawShellcode= File.ReadAllBytes(openFileDialog1.FileName);
                    this.Text = "Encryptor - " + openFileDialog1.FileName;
                    this.EncodeShellcode();

                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
        private void EncodeShellcode()
        {
            // Encode in desired format 
            switch (Properties.Settings.Default.Method)
            {
                case "AES":
                    byte[] iv = new byte[16];
                    Array.Copy(System.Text.Encoding.ASCII.GetBytes(Properties.Settings.Default.AES_IV), 0, iv, 0, Properties.Settings.Default.AES_IV.Length);
                    byte[] key = new byte[32];
                    Array.Copy(System.Text.Encoding.ASCII.GetBytes(Properties.Settings.Default.AES_Key), 0, key, 0, Properties.Settings.Default.AES_Key.Length);
                    EncodedShellcode = Functions.EncryptAES(RawShellcode, key, iv);
                    Encoding_Method = "AES";
                    Encoding_Type = "Encrypted";
                    break;
                case "Caesar":
                    EncodedShellcode = Functions.EncodeCeaser(RawShellcode, Decimal.ToInt32(Properties.Settings.Default.Caesar_Shift));
                    Encoding_Method = "Caesar";
                    Encoding_Type = "Encoded";
                    break;
                case "XOR":
                    EncodedShellcode = Functions.xor(RawShellcode, Encoding.ASCII.GetBytes(Properties.Settings.Default.XOR_Key));
                    Encoding_Method = "XOR";
                    Encoding_Type = "Encoded";
                    break;
                case "XANAX":
                    byte[] xor1 = Encoding.ASCII.GetBytes(Properties.Settings.Default.Xanax_XOR1);
                    byte[] xor2 = Encoding.ASCII.GetBytes(Properties.Settings.Default.Xanax_XOR2);
                    int add1 = Convert.ToInt32(Properties.Settings.Default.Xanax_Add1);
                    int add2 = Convert.ToInt32(Properties.Settings.Default.Xanax_Add2);
                    EncodedShellcode = Functions.EncodeXanax(RawShellcode,xor1[0],add1,add2,xor2[0]);
                    Encoding_Method = "XANAX";
                    Encoding_Type = "Encoded";
                    break;
                case "Insertion":
                    EncodedShellcode = Functions.EncodeInsertion(RawShellcode, Encoding.ASCII.GetBytes(Properties.Settings.Default.Insertion_String), Convert.ToInt32(Properties.Settings.Default.Insertion_Freq));
                    Encoding_Method = "Insertion";
                    Encoding_Type = "Encoded";
                    break;
                default:
                    MessageBox.Show("Unknown encoding method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            DisplayShellcode();
        }
        private void DisplayShellcode()
        { 
            // Display in desired format 
            switch (Properties.Settings.Default.Format)
            {
                case "C#":
                    tbRaw.Text = PrintBytesCSharp(RawShellcode, "sc");
                    tbEncoded.Text = PrintBytesCSharp(EncodedShellcode, "sc");
                    Display_Format = "C#";
                    break;
                case "VBA":
                    tbRaw.Text = PrintBytesVBA(RawShellcode, "sc");
                    tbEncoded.Text = PrintBytesVBA(EncodedShellcode, "sc");
                    Display_Format = "VBA";
                    break;
                case "Base64":
                    Display_Format = "Base64";
                    tbRaw.Text = Convert.ToBase64String(RawShellcode, 0, RawShellcode.Length, Properties.Settings.Default.Split_base64 ? Base64FormattingOptions.InsertLineBreaks : Base64FormattingOptions.None);
                    tbEncoded.Text = Convert.ToBase64String(EncodedShellcode, 0, EncodedShellcode.Length, Properties.Settings.Default.Split_base64 ? Base64FormattingOptions.InsertLineBreaks : Base64FormattingOptions.None);
                    break;
                case "PowerShell":
                    Display_Format = "PowerShell";
                    tbRaw.Text = PrintBytesPowershell(RawShellcode, "sc");
                    tbEncoded.Text = PrintBytesPowershell(EncodedShellcode, "sc"); 
                    break;
                case "C":
                    Display_Format = "C";
                    tbRaw.Text = PrintBytesC(RawShellcode, "sc");
                    tbEncoded.Text = PrintBytesC(EncodedShellcode, "sc"); 
                    break;
                case "Python":
                    Display_Format = "Python";
                    tbRaw.Text = PrintBytesPython(RawShellcode, "sc");
                    tbEncoded.Text = PrintBytesPython(EncodedShellcode, "sc"); 
                    break;
                case "VB Script":
                    Display_Format = "VB Script";
                    tbRaw.Text = PrintBytesVBScript(RawShellcode,"sc");
                    tbEncoded.Text = PrintBytesVBScript(EncodedShellcode, "sc");
                    break;
                case "Text":
                    Display_Format = "Text";
                    tbRaw.Text = Encoding.ASCII.GetString(RawShellcode);
                    tbEncoded.Text = Encoding.ASCII.GetString(EncodedShellcode);
                    break;
                default:
                    MessageBox.Show("Unknown format type:" + Properties.Settings.Default.Format, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbRaw.Text = "";
                    tbEncoded.Text = "";
                    break;
            }
            gbRaw.Text = Display_Format + " Shellcode";
            gbEncoded.Text = Display_Format + " " + Encoding_Method + " " + Encoding_Type + " Shellcode";
            this.Refresh();
        }

        private void rawShellcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRaw.Text);
            MessageBox.Show(gbRaw.Text + " copied to clipboard", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void encodedShellcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbEncoded.Text);
            MessageBox.Show(gbEncoded.Text + " copied to clipboard", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((gbEncoded.Text.Contains("Decoded") == true) || (gbEncoded.Text.Contains("Decrypted") == true))
            {
                MessageBox.Show("Shellcode is already decoded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DecodeShellcode();
            }
            
        }

        private void DecodeShellcode()
        {
            TempShellcode = EncodedShellcode;
            // Decode in desired format 
            switch (Properties.Settings.Default.Method)
            {
                case "AES":
                    byte[] iv = new byte[16];
                    Array.Copy(System.Text.Encoding.ASCII.GetBytes(Properties.Settings.Default.AES_IV), 0, iv, 0, Properties.Settings.Default.AES_IV.Length);
                    byte[] key = new byte[32];
                    Array.Copy(System.Text.Encoding.ASCII.GetBytes(Properties.Settings.Default.AES_Key), 0, key, 0, Properties.Settings.Default.AES_Key.Length);
                    EncodedShellcode = Functions.DecryptAES(TempShellcode, key, iv);
                    Encoding_Method = "AES";
                    Encoding_Type = "Decrypted";
                    break;
                case "Caesar":
                    EncodedShellcode = Functions.DecodeCeaser(TempShellcode, Decimal.ToInt32(Properties.Settings.Default.Caesar_Shift));
                    Encoding_Method = "Caesar";
                    Encoding_Type = "Decoded";
                    break;
                case "XOR":
                    EncodedShellcode = Functions.xor(TempShellcode, Encoding.ASCII.GetBytes(Properties.Settings.Default.XOR_Key));
                    Encoding_Method = "XOR";
                    Encoding_Type = "Decoded";
                    break;
                case "XANAX":
                    byte[] xor1 = Encoding.ASCII.GetBytes(Properties.Settings.Default.Xanax_XOR1);
                    byte[] xor2 = Encoding.ASCII.GetBytes(Properties.Settings.Default.Xanax_XOR2);
                    int add1 = Convert.ToInt32(Properties.Settings.Default.Xanax_Add1);
                    int add2 = Convert.ToInt32(Properties.Settings.Default.Xanax_Add2);
                    EncodedShellcode = Functions.DecodeXanax(TempShellcode, xor1[0] ,add1, add2, xor2[0]);
                    Encoding_Method = "XANAX";
                    Encoding_Type = "Decoded";
                    break;
                case "Insertion":
                    EncodedShellcode = Functions.DecodeInsertion(TempShellcode, Convert.ToInt32(Properties.Settings.Default.Insertion_Freq));
                    Encoding_Method = "Insertion";
                    Encoding_Type = "Decoded";
                    break;
                default:
                    MessageBox.Show("Unknown encoding method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            
            DisplayShellcode();

            if (RawShellcode.SequenceEqual(EncodedShellcode))
            {
                MessageBox.Show(Encoding_Method + " decode test successful", "Decoding", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Encoding_Method + " decode test failed", "Decoding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            menuStrip1.Focus();
        }
        private void saveShellcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((gbEncoded.Text.Contains("Decoded") == true) || (gbEncoded.Text.Contains("Decrypted") == true))
            {
                MessageBox.Show("Shellcode is decoded, please encode prior to saving", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Change this while we write out the settings
                    var OldSplitLines = Properties.Settings.Default.SplitLine;
                    Properties.Settings.Default.SplitLine = 2000;
                    Properties.Settings.Default.Save();
                    try
                    {
                        File.WriteAllBytes(saveFileDialog1.FileName, RawShellcode);
                        File.WriteAllBytes(saveFileDialog1.FileName + "." + Encoding_Method + "-" + Encoding_Type + ".bin", EncodedShellcode);
                        File.WriteAllText(saveFileDialog1.FileName + "." + Display_Format + ".txt", tbRaw.Text);
                        File.WriteAllText(saveFileDialog1.FileName + "." + Display_Format + "-" + Encoding_Method + "-" + Encoding_Type + ".txt", tbEncoded.Text);
                        // Write Out settings 
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("## General Settings");
                        sb.AppendLine();
                        sb.AppendLine("Display Format: " + Properties.Settings.Default.Format);
                        sb.AppendLine(Encoding_Type + " Format: " + Properties.Settings.Default.Method);
                        sb.AppendLine();
                        sb.AppendLine("## " + Encoding_Method + " Settings");
                        sb.AppendLine();
                        byte[] iv = new byte[16];
                        Array.Copy(System.Text.Encoding.ASCII.GetBytes(Properties.Settings.Default.AES_IV), 0, iv, 0, Properties.Settings.Default.AES_IV.Length);
                        byte[] key = new byte[32];
                        Array.Copy(System.Text.Encoding.ASCII.GetBytes(Properties.Settings.Default.AES_Key), 0, key, 0, Properties.Settings.Default.AES_Key.Length);

                        switch (Properties.Settings.Default.Method)
                        {
                            case "AES":
                                sb.AppendLine("AES IV: " + Properties.Settings.Default.AES_IV);
                                sb.AppendLine("AES Key: " + Properties.Settings.Default.AES_Key);
                                sb.AppendLine("AES IV (Base64): " + Convert.ToBase64String(iv, 0, iv.Length, Base64FormattingOptions.None));
                                sb.AppendLine("AES Key (Base64): " + Convert.ToBase64String(key, 0, key.Length, Base64FormattingOptions.None));
                                sb.AppendLine("AES IV (C): " + PrintBytesC(iv, "iv").Replace(Environment.NewLine, "").Replace("\t", ""));
                                sb.AppendLine("AES Key (C): " + PrintBytesC(key, "key").Replace(Environment.NewLine, "").Replace("\t", ""));
                                sb.AppendLine("AES IV (C#): " + PrintBytesCSharp(iv, "iv").Replace(Environment.NewLine, "").Replace("\t", ""));
                                sb.AppendLine("AES Key (C#): " + PrintBytesCSharp(key, "key").Replace(Environment.NewLine, "").Replace("\t", ""));
                                sb.AppendLine("AES IV (PowerShell): " + PrintBytesPowershell(iv, "iv").Replace(Environment.NewLine, "").Replace("\t", ""));
                                sb.AppendLine("AES Key (PowerShell): " + PrintBytesPowershell(key, "key").Replace(Environment.NewLine, "").Replace("\t", ""));
                                sb.AppendLine("AES IV (Python): " + PrintBytesPython(iv, "iv").Replace(Environment.NewLine, "").Replace("\t", "").Replace("=  b\"\"iv +", ""));
                                sb.AppendLine("AES Key (Python): " + PrintBytesPython(key, "key").Replace(Environment.NewLine, "").Replace("\t", "").Replace("=  b\"\"key +", ""));
                                sb.AppendLine("AES IV (VBA): " + PrintBytesVBA(iv, "iv").Replace(Environment.NewLine, "").Replace("\t", ""));
                                sb.AppendLine("AES Key (VBA): " + PrintBytesVBA(key, "key").Replace(Environment.NewLine, "").Replace("\t", ""));
                                sb.AppendLine("AES IV (VB Script): " + PrintBytesVBScript(iv, "iv").Replace(Environment.NewLine, "").Replace("\t", ""));
                                sb.AppendLine("AES Key (VB Script): " + PrintBytesVBScript(key, "key").Replace(Environment.NewLine, "").Replace("\t", ""));
                                break;
                            case "Caesar":
                                sb.AppendLine("Caesar Shift: " + Decimal.ToInt32(Properties.Settings.Default.Caesar_Shift).ToString());
                                break;
                            case "XOR":
                                byte[] xor = Encoding.ASCII.GetBytes(Properties.Settings.Default.XOR_Key);
                                sb.AppendLine("XOR Key: " + Properties.Settings.Default.XOR_Key);
                                sb.AppendLine("XOR Key (Base64): " + Convert.ToBase64String(xor, 0, xor.Length, Base64FormattingOptions.None));
                                sb.AppendLine("XOR Key (C): " + PrintBytesC(xor, "xor").Replace(Environment.NewLine, "").Replace("\t", ""));
                                sb.AppendLine("XOR Key (C#): " + PrintBytesCSharp(xor, "xor").Replace(Environment.NewLine, "").Replace("\t", ""));
                                sb.AppendLine("XOR Key (PowerShell): " + PrintBytesPowershell(xor, "xor").Replace(Environment.NewLine, "").Replace("\t", ""));
                                sb.AppendLine("XOR Key (Python): " + PrintBytesPython(xor, "xor").Replace(Environment.NewLine, "").Replace("\t", "").Replace("=  b\"\"xor +", ""));
                                sb.AppendLine("XOR Key (VBA): " + PrintBytesVBA(xor, "xor").Replace(Environment.NewLine, "").Replace("\t", ""));
                                sb.AppendLine("XOR Key (VB Script): " + PrintBytesVBScript(xor, "xor").Replace(Environment.NewLine, "").Replace("\t", ""));
                                break;
                            case "XANAX":
                                sb.AppendLine("Xanax XOR1: " + Properties.Settings.Default.Xanax_XOR1);
                                sb.AppendLine("Xanax Add1: " + Properties.Settings.Default.Xanax_Add1);
                                sb.AppendLine("Xanax XOR2: " + Properties.Settings.Default.Xanax_XOR2);
                                sb.AppendLine("Xanax Add2: " + Properties.Settings.Default.Xanax_Add2);
                                break;
                            case "Insertion":
                                byte[] InsertionBytes = Encoding.ASCII.GetBytes(Properties.Settings.Default.Insertion_String);
                                sb.AppendLine("Insertion Frequency: " + Decimal.ToInt32(Properties.Settings.Default.Insertion_Freq).ToString());
                                sb.AppendLine("Insertion Key: " + Properties.Settings.Default.Insertion_String);
                                sb.AppendLine("Insertion Key (Base64): " + Convert.ToBase64String(InsertionBytes, 0, InsertionBytes.Length, Base64FormattingOptions.None));
                                sb.AppendLine("Insertion Key (C): " + PrintBytesC(InsertionBytes, "InsertBytes").Replace(Environment.NewLine, "").Replace("\t", ""));
                                sb.AppendLine("Insertion Key (C#): " + PrintBytesCSharp(InsertionBytes, "InsertBytes").Replace(Environment.NewLine, "").Replace("\t", ""));
                                sb.AppendLine("Insertion Key (PowerShell): " + PrintBytesPowershell(InsertionBytes, "InsertBytes").Replace(Environment.NewLine, "").Replace("\t", ""));
                                sb.AppendLine("Insertion Key (Python): " + PrintBytesPython(InsertionBytes, "InsertBytes").Replace(Environment.NewLine, "").Replace("\t", "").Replace("=  b\"\"InsertBytes +", ""));
                                sb.AppendLine("Insertion Key (VBA): " + PrintBytesVBA(InsertionBytes, "InsertBytes").Replace(Environment.NewLine, "").Replace("\t", ""));
                                sb.AppendLine("Insertion Key (VB Script): " + PrintBytesVBScript(InsertionBytes, "InsertBytes").Replace(Environment.NewLine, "").Replace("\t", ""));
                                break;
                            default:
                                MessageBox.Show("Unknown encoding method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }
                        File.WriteAllText(saveFileDialog1.FileName + ".Settings.txt", sb.ToString());
                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                        $"Details:\n\n{ex.StackTrace}");
                    }
                    finally {
                        // Put this back 
                        Properties.Settings.Default.SplitLine = OldSplitLines;
                        Properties.Settings.Default.Save();
                    }
                }
            }
        }
        // Print Bytes as C# definition 
        public static string PrintBytesCSharp(byte[] byteArray, string VariableName)
        {
            var sb = new StringBuilder("byte[] " + VariableName + " = new byte[" + byteArray.Length.ToString() + "] { " + Environment.NewLine + String.Concat(Enumerable.Repeat("\t", Decimal.ToInt32(Properties.Settings.Default.Tabs))));
            int counter = 0;
            foreach (byte b in byteArray)
            {
                sb.AppendFormat("0x{0:x2}, ", b);
                counter++;
                if (counter % Properties.Settings.Default.SplitLine == 0)
                {
                    sb.Append(Environment.NewLine + String.Concat(Enumerable.Repeat("\t", Decimal.ToInt32(Properties.Settings.Default.Tabs))));
                    counter = 0;
                }

            }
            sb.Remove(sb.Length - 2, 2);
            sb.Append("};");
            return sb.ToString();
        }
        // Print bytes as a C definition
        public static string PrintBytesC(byte[] byteArray, string VariableName)
        {
            var sb = new StringBuilder("unsigned char " + VariableName + "[] = " + Environment.NewLine + String.Concat(Enumerable.Repeat("\t", Decimal.ToInt32(Properties.Settings.Default.Tabs))) + "\"");
            int counter = 0;
            foreach (byte b in byteArray)
            {
                sb.AppendFormat("\\x{0:x2}", b);
                counter++;
                if (counter % Properties.Settings.Default.SplitLine == 0)
                {
                    sb.Append("\"" + Environment.NewLine + String.Concat(Enumerable.Repeat("\t", Decimal.ToInt32(Properties.Settings.Default.Tabs))) + "\"");
                    counter = 0;
                }

            }
            sb.Append("\";");
            return sb.ToString();
        }
        // Print Bytes as VBA definition 
        public static string PrintBytesVBA(byte[] byteArray, string VariableName)
        {
            var sb = new StringBuilder(VariableName + " = Array(");
            int counter = 0;
            foreach (byte b in byteArray)
            {
                sb.AppendFormat("{0:D}, ", b);
                counter++;
                if (counter % Properties.Settings.Default.SplitLine == 0)
                {
                    sb.AppendFormat("_{0}", Environment.NewLine + String.Concat(Enumerable.Repeat("\t", Decimal.ToInt32(Properties.Settings.Default.Tabs))));
                }
            }
            sb.Remove(sb.Length - 2, 2);
            sb.Append(")");
            return sb.ToString();
        }
        // Print Bytes as VB Script definition 
        public static string PrintBytesVBScript(byte[] byteArray, string VariableName)
        {
            var sb = new StringBuilder(VariableName + "=");
            int counter = 0;
            foreach (byte b in byteArray)
            {
                sb.AppendFormat("Chr({0:D})", b);
                counter++;
                if (counter % Properties.Settings.Default.SplitLine == 0)
                {
                    sb.Append(Environment.NewLine + "sc=sc&");
                }
                else
                {
                    sb.Append("&");
                }
            }
            sb.Remove(sb.Length - 1, 1);
            //sb.Append(")");
            return sb.ToString();
        }
        // Print Bytes as Powershell definition 
        public static string PrintBytesPowershell(byte[] byteArray, string VariableName)
        {
            var sb = new StringBuilder("[Byte[]] $" + VariableName + " =" + Environment.NewLine + String.Concat(Enumerable.Repeat("\t", Decimal.ToInt32(Properties.Settings.Default.Tabs))));
            int counter = 0;
            foreach (byte b in byteArray)
            {
                sb.AppendFormat("0x{0:x2}, ", b);
                counter++;
                if (counter % Properties.Settings.Default.SplitLine == 0)
                {
                    sb.Append(Environment.NewLine + String.Concat(Enumerable.Repeat("\t", Decimal.ToInt32(Properties.Settings.Default.Tabs))));
                }
            }
            sb.Remove(sb.Length - 2, 2);
            sb.Append(";");
            return sb.ToString();
        }
        // Print bytes as a Python definition
        public static string PrintBytesPython(byte[] byteArray, string VariableName)
        {
            var sb = new StringBuilder(VariableName + " =  b\"\"" + Environment.NewLine + VariableName + " += b\"");
            int counter = 0;
            foreach (byte b in byteArray)
            {
                sb.AppendFormat("\\x{0:x2}", b);
                counter++;
                if (counter % Properties.Settings.Default.SplitLine == 0)
                {
                    sb.Append("\"" + Environment.NewLine + VariableName + " += b\"");
                    counter = 0;
                }
            }
            sb.Append("\"");
            return sb.ToString();
        }
    }
}

