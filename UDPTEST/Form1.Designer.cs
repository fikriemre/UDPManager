namespace UDPTEST
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.bt_ip = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.cb_byte = new System.Windows.Forms.CheckBox();
            this.txt_bsize = new System.Windows.Forms.TextBox();
            this.cb_aliciyok = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 425);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(647, 142);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 142);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(735, 377);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.Resize += new System.EventHandler(this.richTextBox1_Resize);
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(13, 13);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(158, 20);
            this.txt_ip.TabIndex = 3;
            // 
            // bt_ip
            // 
            this.bt_ip.Location = new System.Drawing.Point(387, 12);
            this.bt_ip.Name = "bt_ip";
            this.bt_ip.Size = new System.Drawing.Size(75, 23);
            this.bt_ip.TabIndex = 4;
            this.bt_ip.Text = "SET CONN";
            this.bt_ip.UseVisualStyleBackColor = true;
            this.bt_ip.Click += new System.EventHandler(this.bt_ip_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(665, 13);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(75, 23);
            this.bt_clear.TabIndex = 4;
            this.bt_clear.Text = "CLEAR";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "GET IP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(258, 14);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(53, 20);
            this.txt_port.TabIndex = 3;
            this.txt_port.Text = "8880";
            // 
            // cb_byte
            // 
            this.cb_byte.AutoSize = true;
            this.cb_byte.Location = new System.Drawing.Point(588, 17);
            this.cb_byte.Name = "cb_byte";
            this.cb_byte.Size = new System.Drawing.Size(71, 17);
            this.cb_byte.TabIndex = 5;
            this.cb_byte.Text = "byte dinle";
            this.cb_byte.UseVisualStyleBackColor = true;
            // 
            // txt_bsize
            // 
            this.txt_bsize.Location = new System.Drawing.Point(317, 13);
            this.txt_bsize.Name = "txt_bsize";
            this.txt_bsize.Size = new System.Drawing.Size(64, 20);
            this.txt_bsize.TabIndex = 3;
            this.txt_bsize.Text = "1024";
            // 
            // cb_aliciyok
            // 
            this.cb_aliciyok.AutoSize = true;
            this.cb_aliciyok.Location = new System.Drawing.Point(478, 16);
            this.cb_aliciyok.Name = "cb_aliciyok";
            this.cb_aliciyok.Size = new System.Drawing.Size(82, 17);
            this.cb_aliciyok.TabIndex = 5;
            this.cb_aliciyok.Text = "alıcı olmasın";
            this.cb_aliciyok.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyIcon1.BalloonTipText = "AAAA";
            this.notifyIcon1.BalloonTipTitle = "BBBBB";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 591);
            this.Controls.Add(this.cb_aliciyok);
            this.Controls.Add(this.cb_byte);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_ip);
            this.Controls.Add(this.txt_bsize);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Button bt_ip;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.CheckBox cb_byte;
        private System.Windows.Forms.TextBox txt_bsize;
        private System.Windows.Forms.CheckBox cb_aliciyok;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

