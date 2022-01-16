
namespace Encryptor
{
    partial class frmOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkBase64SplitLines = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTabs = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownSplitLines = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbXOR = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericUpDownCaesar = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.tbIV = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.tpFormat = new System.Windows.Forms.TabPage();
            this.tpEncoding = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpAES = new System.Windows.Forms.TabPage();
            this.tpXOR = new System.Windows.Forms.TabPage();
            this.tpCaesar = new System.Windows.Forms.TabPage();
            this.tpXanax = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tbXanaxXOR2 = new System.Windows.Forms.TextBox();
            this.nudXanaxAdd2 = new System.Windows.Forms.NumericUpDown();
            this.nudXanaxAdd1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tbXanaxXOR1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblXor = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGenerateInsertionString = new System.Windows.Forms.Button();
            this.nudInsertionFreq = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbInsertionString = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTabs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSplitLines)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCaesar)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpFormat.SuspendLayout();
            this.tpEncoding.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpAES.SuspendLayout();
            this.tpXOR.SuspendLayout();
            this.tpCaesar.SuspendLayout();
            this.tpXanax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXanaxAdd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXanaxAdd1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInsertionFreq)).BeginInit();
            this.SuspendLayout();
            // 
            // chkBase64SplitLines
            // 
            this.chkBase64SplitLines.AutoSize = true;
            this.chkBase64SplitLines.Location = new System.Drawing.Point(18, 83);
            this.chkBase64SplitLines.Margin = new System.Windows.Forms.Padding(2);
            this.chkBase64SplitLines.Name = "chkBase64SplitLines";
            this.chkBase64SplitLines.Size = new System.Drawing.Size(120, 17);
            this.chkBase64SplitLines.TabIndex = 4;
            this.chkBase64SplitLines.Text = "Split Base64 Strings";
            this.chkBase64SplitLines.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Insert Tabs";
            // 
            // nudTabs
            // 
            this.nudTabs.Location = new System.Drawing.Point(192, 50);
            this.nudTabs.Margin = new System.Windows.Forms.Padding(2);
            this.nudTabs.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudTabs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTabs.Name = "nudTabs";
            this.nudTabs.Size = new System.Drawing.Size(90, 20);
            this.nudTabs.TabIndex = 2;
            this.nudTabs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Split lines after this many bytes";
            // 
            // numericUpDownSplitLines
            // 
            this.numericUpDownSplitLines.Location = new System.Drawing.Point(192, 19);
            this.numericUpDownSplitLines.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownSplitLines.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownSplitLines.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSplitLines.Name = "numericUpDownSplitLines";
            this.numericUpDownSplitLines.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownSplitLines.TabIndex = 0;
            this.numericUpDownSplitLines.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbXOR);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(290, 149);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "XOR Key";
            // 
            // tbXOR
            // 
            this.tbXOR.Location = new System.Drawing.Point(4, 17);
            this.tbXOR.Margin = new System.Windows.Forms.Padding(2);
            this.tbXOR.MaxLength = 255;
            this.tbXOR.Name = "tbXOR";
            this.tbXOR.Size = new System.Drawing.Size(158, 20);
            this.tbXOR.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDownCaesar);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(296, 155);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Shift bytes by";
            // 
            // numericUpDownCaesar
            // 
            this.numericUpDownCaesar.Location = new System.Drawing.Point(4, 17);
            this.numericUpDownCaesar.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownCaesar.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownCaesar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCaesar.Name = "numericUpDownCaesar";
            this.numericUpDownCaesar.Size = new System.Drawing.Size(79, 20);
            this.numericUpDownCaesar.TabIndex = 0;
            this.numericUpDownCaesar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnGenerate);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.tbKey);
            this.groupBox6.Controls.Add(this.tbIV);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(290, 149);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "AES Settings";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(209, 71);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IV";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(51, 45);
            this.tbKey.MaxLength = 32;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(233, 20);
            this.tbKey.TabIndex = 1;
            // 
            // tbIV
            // 
            this.tbIV.Location = new System.Drawing.Point(51, 19);
            this.tbIV.MaxLength = 16;
            this.tbIV.Name = "tbIV";
            this.tbIV.Size = new System.Drawing.Size(233, 20);
            this.tbIV.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpGeneral);
            this.tabControl1.Controls.Add(this.tpFormat);
            this.tabControl1.Controls.Add(this.tpEncoding);
            this.tabControl1.Location = new System.Drawing.Point(2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(318, 213);
            this.tabControl1.TabIndex = 8;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.linkLabel1);
            this.tpGeneral.Controls.Add(this.groupBox2);
            this.tpGeneral.Controls.Add(this.groupBox1);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(310, 187);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 159);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(171, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/su1s/encryptor";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbMethod);
            this.groupBox2.Location = new System.Drawing.Point(5, 56);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(300, 47);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encryption/Encoding Method";
            // 
            // cmbMethod
            // 
            this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Items.AddRange(new object[] {
            "AES",
            "Caesar",
            "Insertion",
            "XANAX",
            "XOR"});
            this.cmbMethod.Location = new System.Drawing.Point(4, 17);
            this.cmbMethod.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(292, 21);
            this.cmbMethod.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFormat);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(300, 47);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output Format";
            // 
            // cmbFormat
            // 
            this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Items.AddRange(new object[] {
            "Base64",
            "C",
            "C#",
            "PowerShell",
            "Python",
            "Text",
            "VBA",
            "VB Script"});
            this.cmbFormat.Location = new System.Drawing.Point(4, 17);
            this.cmbFormat.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(292, 21);
            this.cmbFormat.TabIndex = 0;
            // 
            // tpFormat
            // 
            this.tpFormat.Controls.Add(this.chkBase64SplitLines);
            this.tpFormat.Controls.Add(this.label4);
            this.tpFormat.Controls.Add(this.nudTabs);
            this.tpFormat.Controls.Add(this.label3);
            this.tpFormat.Controls.Add(this.numericUpDownSplitLines);
            this.tpFormat.Location = new System.Drawing.Point(4, 22);
            this.tpFormat.Name = "tpFormat";
            this.tpFormat.Padding = new System.Windows.Forms.Padding(3);
            this.tpFormat.Size = new System.Drawing.Size(310, 187);
            this.tpFormat.TabIndex = 1;
            this.tpFormat.Text = "Formatting";
            this.tpFormat.UseVisualStyleBackColor = true;
            // 
            // tpEncoding
            // 
            this.tpEncoding.Controls.Add(this.tabControl2);
            this.tpEncoding.Location = new System.Drawing.Point(4, 22);
            this.tpEncoding.Name = "tpEncoding";
            this.tpEncoding.Padding = new System.Windows.Forms.Padding(3);
            this.tpEncoding.Size = new System.Drawing.Size(310, 187);
            this.tpEncoding.TabIndex = 2;
            this.tpEncoding.Text = "Encoding";
            this.tpEncoding.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tpAES);
            this.tabControl2.Controls.Add(this.tpXOR);
            this.tabControl2.Controls.Add(this.tpCaesar);
            this.tabControl2.Controls.Add(this.tpXanax);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(304, 181);
            this.tabControl2.TabIndex = 0;
            // 
            // tpAES
            // 
            this.tpAES.Controls.Add(this.groupBox6);
            this.tpAES.Location = new System.Drawing.Point(4, 22);
            this.tpAES.Name = "tpAES";
            this.tpAES.Padding = new System.Windows.Forms.Padding(3);
            this.tpAES.Size = new System.Drawing.Size(296, 155);
            this.tpAES.TabIndex = 0;
            this.tpAES.Text = "AES";
            this.tpAES.UseVisualStyleBackColor = true;
            // 
            // tpXOR
            // 
            this.tpXOR.Controls.Add(this.groupBox4);
            this.tpXOR.Location = new System.Drawing.Point(4, 22);
            this.tpXOR.Name = "tpXOR";
            this.tpXOR.Padding = new System.Windows.Forms.Padding(3);
            this.tpXOR.Size = new System.Drawing.Size(296, 155);
            this.tpXOR.TabIndex = 1;
            this.tpXOR.Text = "XOR";
            this.tpXOR.UseVisualStyleBackColor = true;
            // 
            // tpCaesar
            // 
            this.tpCaesar.Controls.Add(this.groupBox5);
            this.tpCaesar.Location = new System.Drawing.Point(4, 22);
            this.tpCaesar.Name = "tpCaesar";
            this.tpCaesar.Size = new System.Drawing.Size(296, 155);
            this.tpCaesar.TabIndex = 2;
            this.tpCaesar.Text = "Caeser";
            this.tpCaesar.UseVisualStyleBackColor = true;
            // 
            // tpXanax
            // 
            this.tpXanax.Controls.Add(this.label5);
            this.tpXanax.Controls.Add(this.tbXanaxXOR2);
            this.tpXanax.Controls.Add(this.nudXanaxAdd2);
            this.tpXanax.Controls.Add(this.nudXanaxAdd1);
            this.tpXanax.Controls.Add(this.label8);
            this.tpXanax.Controls.Add(this.tbXanaxXOR1);
            this.tpXanax.Controls.Add(this.label7);
            this.tpXanax.Controls.Add(this.label6);
            this.tpXanax.Controls.Add(this.lblXor);
            this.tpXanax.Location = new System.Drawing.Point(4, 22);
            this.tpXanax.Name = "tpXanax";
            this.tpXanax.Size = new System.Drawing.Size(296, 155);
            this.tpXanax.TabIndex = 3;
            this.tpXanax.Text = "Xanax";
            this.tpXanax.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Xor";
            // 
            // tbXanaxXOR2
            // 
            this.tbXanaxXOR2.Location = new System.Drawing.Point(71, 117);
            this.tbXanaxXOR2.Name = "tbXanaxXOR2";
            this.tbXanaxXOR2.Size = new System.Drawing.Size(76, 20);
            this.tbXanaxXOR2.TabIndex = 3;
            // 
            // nudXanaxAdd2
            // 
            this.nudXanaxAdd2.Location = new System.Drawing.Point(71, 91);
            this.nudXanaxAdd2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudXanaxAdd2.Name = "nudXanaxAdd2";
            this.nudXanaxAdd2.Size = new System.Drawing.Size(76, 20);
            this.nudXanaxAdd2.TabIndex = 2;
            // 
            // nudXanaxAdd1
            // 
            this.nudXanaxAdd1.Location = new System.Drawing.Point(71, 39);
            this.nudXanaxAdd1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudXanaxAdd1.Name = "nudXanaxAdd1";
            this.nudXanaxAdd1.Size = new System.Drawing.Size(76, 20);
            this.nudXanaxAdd1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Add";
            // 
            // tbXanaxXOR1
            // 
            this.tbXanaxXOR1.Location = new System.Drawing.Point(71, 12);
            this.tbXanaxXOR1.Name = "tbXanaxXOR1";
            this.tbXanaxXOR1.Size = new System.Drawing.Size(76, 20);
            this.tbXanaxXOR1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Not";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Add";
            // 
            // lblXor
            // 
            this.lblXor.AutoSize = true;
            this.lblXor.Location = new System.Drawing.Point(16, 15);
            this.lblXor.Name = "lblXor";
            this.lblXor.Size = new System.Drawing.Size(23, 13);
            this.lblXor.TabIndex = 0;
            this.lblXor.Text = "Xor";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGenerateInsertionString);
            this.tabPage1.Controls.Add(this.nudInsertionFreq);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.tbInsertionString);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(296, 155);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Insertion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGenerateInsertionString
            // 
            this.btnGenerateInsertionString.Location = new System.Drawing.Point(203, 66);
            this.btnGenerateInsertionString.Name = "btnGenerateInsertionString";
            this.btnGenerateInsertionString.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateInsertionString.TabIndex = 2;
            this.btnGenerateInsertionString.Text = "Generate";
            this.btnGenerateInsertionString.UseVisualStyleBackColor = true;
            this.btnGenerateInsertionString.Click += new System.EventHandler(this.btnGenerateInsertionString_Click);
            // 
            // nudInsertionFreq
            // 
            this.nudInsertionFreq.Location = new System.Drawing.Point(96, 42);
            this.nudInsertionFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInsertionFreq.Name = "nudInsertionFreq";
            this.nudInsertionFreq.Size = new System.Drawing.Size(68, 20);
            this.nudInsertionFreq.TabIndex = 1;
            this.nudInsertionFreq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Frequency";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Insertion String";
            // 
            // tbInsertionString
            // 
            this.tbInsertionString.Location = new System.Drawing.Point(96, 14);
            this.tbInsertionString.MaxLength = 255;
            this.tbInsertionString.Name = "tbInsertionString";
            this.tbInsertionString.Size = new System.Drawing.Size(182, 20);
            this.tbInsertionString.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(259, 213);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 19);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(198, 213);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(56, 19);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 239);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTabs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSplitLines)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCaesar)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tpFormat.ResumeLayout(false);
            this.tpFormat.PerformLayout();
            this.tpEncoding.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tpAES.ResumeLayout(false);
            this.tpXOR.ResumeLayout(false);
            this.tpCaesar.ResumeLayout(false);
            this.tpXanax.ResumeLayout(false);
            this.tpXanax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudXanaxAdd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXanaxAdd1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInsertionFreq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown numericUpDownCaesar;
        private System.Windows.Forms.NumericUpDown numericUpDownSplitLines;
        private System.Windows.Forms.TextBox tbXOR;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TextBox tbIV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTabs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkBase64SplitLines;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.TabPage tpFormat;
        private System.Windows.Forms.TabPage tpEncoding;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpAES;
        private System.Windows.Forms.TabPage tpXOR;
        private System.Windows.Forms.TabPage tpCaesar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabPage tpXanax;
        private System.Windows.Forms.NumericUpDown nudXanaxAdd1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbXanaxXOR1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblXor;
        private System.Windows.Forms.TextBox tbXanaxXOR2;
        private System.Windows.Forms.NumericUpDown nudXanaxAdd2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbInsertionString;
        private System.Windows.Forms.Button btnGenerateInsertionString;
        private System.Windows.Forms.NumericUpDown nudInsertionFreq;
        private System.Windows.Forms.Label label10;
    }
}