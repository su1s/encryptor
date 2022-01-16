
namespace Encryptor
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadShellcodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveShellcodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawShellcodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodedShellcodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbEncoded = new System.Windows.Forms.GroupBox();
            this.tbEncoded = new System.Windows.Forms.TextBox();
            this.gbRaw = new System.Windows.Forms.GroupBox();
            this.tbRaw = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbEncoded.SuspendLayout();
            this.gbRaw.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadShellcodeToolStripMenuItem,
            this.saveShellcodeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadShellcodeToolStripMenuItem
            // 
            this.loadShellcodeToolStripMenuItem.Name = "loadShellcodeToolStripMenuItem";
            this.loadShellcodeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.loadShellcodeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.loadShellcodeToolStripMenuItem.Text = "Load Shellcode";
            this.loadShellcodeToolStripMenuItem.Click += new System.EventHandler(this.loadShellcodeToolStripMenuItem_Click);
            // 
            // saveShellcodeToolStripMenuItem
            // 
            this.saveShellcodeToolStripMenuItem.Name = "saveShellcodeToolStripMenuItem";
            this.saveShellcodeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.saveShellcodeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.saveShellcodeToolStripMenuItem.Text = "Save Shellcode";
            this.saveShellcodeToolStripMenuItem.Click += new System.EventHandler(this.saveShellcodeToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rawShellcodeToolStripMenuItem,
            this.encodedShellcodeToolStripMenuItem});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // rawShellcodeToolStripMenuItem
            // 
            this.rawShellcodeToolStripMenuItem.Name = "rawShellcodeToolStripMenuItem";
            this.rawShellcodeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.rawShellcodeToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.rawShellcodeToolStripMenuItem.Text = "Raw Shellcode";
            this.rawShellcodeToolStripMenuItem.Click += new System.EventHandler(this.rawShellcodeToolStripMenuItem_Click);
            // 
            // encodedShellcodeToolStripMenuItem
            // 
            this.encodedShellcodeToolStripMenuItem.Name = "encodedShellcodeToolStripMenuItem";
            this.encodedShellcodeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.encodedShellcodeToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.encodedShellcodeToolStripMenuItem.Text = "Encoded Shellcode";
            this.encodedShellcodeToolStripMenuItem.Click += new System.EventHandler(this.encodedShellcodeToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem1,
            this.testToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.optionsToolStripMenuItem1.Text = "Options";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.optionsToolStripMenuItem1_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.testToolStripMenuItem.Text = "Decode Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1110, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbEncoded, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbRaw, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1110, 602);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // gbEncoded
            // 
            this.gbEncoded.Controls.Add(this.tbEncoded);
            this.gbEncoded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEncoded.Location = new System.Drawing.Point(557, 2);
            this.gbEncoded.Margin = new System.Windows.Forms.Padding(2);
            this.gbEncoded.Name = "gbEncoded";
            this.gbEncoded.Padding = new System.Windows.Forms.Padding(2);
            this.gbEncoded.Size = new System.Drawing.Size(551, 598);
            this.gbEncoded.TabIndex = 1;
            this.gbEncoded.TabStop = false;
            this.gbEncoded.Text = "Encoded Shellcode";
            // 
            // tbEncoded
            // 
            this.tbEncoded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEncoded.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEncoded.Location = new System.Drawing.Point(2, 15);
            this.tbEncoded.Margin = new System.Windows.Forms.Padding(2);
            this.tbEncoded.Multiline = true;
            this.tbEncoded.Name = "tbEncoded";
            this.tbEncoded.ReadOnly = true;
            this.tbEncoded.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEncoded.Size = new System.Drawing.Size(547, 581);
            this.tbEncoded.TabIndex = 1;
            // 
            // gbRaw
            // 
            this.gbRaw.Controls.Add(this.tbRaw);
            this.gbRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRaw.Location = new System.Drawing.Point(2, 2);
            this.gbRaw.Margin = new System.Windows.Forms.Padding(2);
            this.gbRaw.Name = "gbRaw";
            this.gbRaw.Padding = new System.Windows.Forms.Padding(2);
            this.gbRaw.Size = new System.Drawing.Size(551, 598);
            this.gbRaw.TabIndex = 0;
            this.gbRaw.TabStop = false;
            this.gbRaw.Text = "Raw Shellcode";
            // 
            // tbRaw
            // 
            this.tbRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRaw.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRaw.Location = new System.Drawing.Point(2, 15);
            this.tbRaw.Margin = new System.Windows.Forms.Padding(2);
            this.tbRaw.Multiline = true;
            this.tbRaw.Name = "tbRaw";
            this.tbRaw.ReadOnly = true;
            this.tbRaw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRaw.Size = new System.Drawing.Size(547, 581);
            this.tbRaw.TabIndex = 0;
            this.tbRaw.Text = "Use file > Load menu to begin";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1110, 626);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryptor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbEncoded.ResumeLayout(false);
            this.gbEncoded.PerformLayout();
            this.gbRaw.ResumeLayout(false);
            this.gbRaw.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadShellcodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveShellcodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rawShellcodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encodedShellcodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbEncoded;
        private System.Windows.Forms.TextBox tbEncoded;
        private System.Windows.Forms.GroupBox gbRaw;
        private System.Windows.Forms.TextBox tbRaw;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}