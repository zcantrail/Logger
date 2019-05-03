namespace AccessLog
{
    partial class Log
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.microsoftToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearWindowsCredentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMicrosoftProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DialogBox = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.microsoftToolsToolStripMenuItem,
            this.clearFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // microsoftToolsToolStripMenuItem
            // 
            this.microsoftToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearWindowsCredentialsToolStripMenuItem,
            this.closeMicrosoftProductsToolStripMenuItem});
            this.microsoftToolsToolStripMenuItem.Name = "microsoftToolsToolStripMenuItem";
            this.microsoftToolsToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.microsoftToolsToolStripMenuItem.Text = "Microsoft tools";
            // 
            // clearWindowsCredentialsToolStripMenuItem
            // 
            this.clearWindowsCredentialsToolStripMenuItem.Name = "clearWindowsCredentialsToolStripMenuItem";
            this.clearWindowsCredentialsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.clearWindowsCredentialsToolStripMenuItem.Text = "Clear Windows Credentials";
            this.clearWindowsCredentialsToolStripMenuItem.Click += new System.EventHandler(this.ClearWindowsCredentialsToolStripMenuItem_Click);
            // 
            // closeMicrosoftProductsToolStripMenuItem
            // 
            this.closeMicrosoftProductsToolStripMenuItem.Name = "closeMicrosoftProductsToolStripMenuItem";
            this.closeMicrosoftProductsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.closeMicrosoftProductsToolStripMenuItem.Text = "Close microsoft products";
            this.closeMicrosoftProductsToolStripMenuItem.Click += new System.EventHandler(this.CloseMicrosoftProductsToolStripMenuItem_Click);
            // 
            // clearFormToolStripMenuItem
            // 
            this.clearFormToolStripMenuItem.Name = "clearFormToolStripMenuItem";
            this.clearFormToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.clearFormToolStripMenuItem.Text = "Clear Form";
            this.clearFormToolStripMenuItem.Click += new System.EventHandler(this.ClearFormToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DialogBox
            // 
            this.DialogBox.Location = new System.Drawing.Point(12, 53);
            this.DialogBox.Name = "DialogBox";
            this.DialogBox.Size = new System.Drawing.Size(460, 228);
            this.DialogBox.TabIndex = 5;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 290);
            this.Controls.Add(this.DialogBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Log";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Log_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem microsoftToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearWindowsCredentialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeMicrosoftProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFormToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DialogBox;
    }
}

