namespace SAMPLE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            setting = new Button();
            qfileIP = new Button();
            ipaddress = new Label();
            groupBox1 = new GroupBox();
            qfileDO = new Button();
            domain = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // setting
            // 
            setting.Location = new Point(674, 56);
            setting.Name = "setting";
            setting.Size = new Size(94, 29);
            setting.TabIndex = 0;
            setting.Text = "設定";
            setting.UseVisualStyleBackColor = true;
            setting.Click += setting_Click;
            // 
            // qfileIP
            // 
            qfileIP.Location = new Point(31, 49);
            qfileIP.Name = "qfileIP";
            qfileIP.Size = new Size(200, 58);
            qfileIP.TabIndex = 1;
            qfileIP.Text = "接続\r\n（IP）";
            qfileIP.UseVisualStyleBackColor = true;
            qfileIP.Click += qfileIP_Click;
            // 
            // ipaddress
            // 
            ipaddress.AutoSize = true;
            ipaddress.Location = new Point(31, 138);
            ipaddress.Name = "ipaddress";
            ipaddress.Size = new Size(21, 20);
            ipaddress.TabIndex = 2;
            ipaddress.Text = "IP";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(domain);
            groupBox1.Controls.Add(qfileDO);
            groupBox1.Controls.Add(ipaddress);
            groupBox1.Controls.Add(qfileIP);
            groupBox1.Location = new Point(53, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(509, 196);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "共有フォルダ（アクセス）";
            // 
            // qfileDO
            // 
            qfileDO.Location = new Point(237, 49);
            qfileDO.Name = "qfileDO";
            qfileDO.Size = new Size(200, 58);
            qfileDO.TabIndex = 2;
            qfileDO.Text = "接続\r\n（ドメイン）";
            qfileDO.UseVisualStyleBackColor = true;
            qfileDO.Click += qfileDO_Click;
            // 
            // domain
            // 
            domain.AutoSize = true;
            domain.Location = new Point(237, 138);
            domain.Name = "domain";
            domain.Size = new Size(31, 20);
            domain.TabIndex = 4;
            domain.Text = "DO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 496);
            Controls.Add(groupBox1);
            Controls.Add(setting);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button setting;
        private Button qfileIP;
        private Label ipaddress;
        private GroupBox groupBox1;
        private Button qfileDO;
        private Label domain;
    }
}
