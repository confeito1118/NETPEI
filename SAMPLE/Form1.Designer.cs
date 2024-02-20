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
            domain = new Label();
            qfileDO = new Button();
            groupBox2 = new GroupBox();
            sessCheck = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // setting
            // 
            setting.Location = new Point(845, 34);
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
            ipaddress.Location = new Point(31, 119);
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
            groupBox1.Size = new Size(509, 156);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "共有フォルダ（アクセス）";
            // 
            // domain
            // 
            domain.AutoSize = true;
            domain.Location = new Point(237, 119);
            domain.Name = "domain";
            domain.Size = new Size(31, 20);
            domain.TabIndex = 4;
            domain.Text = "DO";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(sessCheck);
            groupBox2.Location = new Point(596, 76);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(370, 226);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // sessCheck
            // 
            sessCheck.Location = new Point(20, 49);
            sessCheck.Name = "sessCheck";
            sessCheck.Size = new Size(200, 58);
            sessCheck.TabIndex = 5;
            sessCheck.Text = "接続\r\n（ドメイン）";
            sessCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 539);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(setting);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button setting;
        private Button qfileIP;
        private Label ipaddress;
        private GroupBox groupBox1;
        private Button qfileDO;
        private Label domain;
        private GroupBox groupBox2;
        private Button sessCheck;
    }
}
