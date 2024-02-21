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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            setting = new Button();
            qfileIP = new Button();
            ipaddress = new Label();
            groupBox1 = new GroupBox();
            domain = new Label();
            qfileDO = new Button();
            groupBox2 = new GroupBox();
            btnReboot = new Button();
            sessDelete = new Button();
            sessCheck = new Button();
            uxCommand = new TextBox();
            menuStrip1 = new MenuStrip();
            ファイルFToolStripMenuItem = new ToolStripMenuItem();
            cnIPIToolStripMenuItem = new ToolStripMenuItem();
            cnDODToolStripMenuItem = new ToolStripMenuItem();
            sessCheckCToolStripMenuItem = new ToolStripMenuItem();
            sessDeleteEToolStripMenuItem = new ToolStripMenuItem();
            pcRebootRToolStripMenuItem = new ToolStripMenuItem();
            closeWToolStripMenuItem = new ToolStripMenuItem();
            SettingSToolStripMenuItem = new ToolStripMenuItem();
            versionVToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // setting
            // 
            setting.Location = new Point(468, 41);
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
            groupBox2.Controls.Add(btnReboot);
            groupBox2.Controls.Add(sessDelete);
            groupBox2.Controls.Add(sessCheck);
            groupBox2.Location = new Point(596, 76);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(669, 156);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnReboot
            // 
            btnReboot.Location = new Point(432, 49);
            btnReboot.Name = "btnReboot";
            btnReboot.Size = new Size(200, 58);
            btnReboot.TabIndex = 7;
            btnReboot.Text = "再起動";
            btnReboot.UseVisualStyleBackColor = true;
            btnReboot.Click += btnReboot_Click;
            // 
            // sessDelete
            // 
            sessDelete.Location = new Point(226, 49);
            sessDelete.Name = "sessDelete";
            sessDelete.Size = new Size(200, 58);
            sessDelete.TabIndex = 6;
            sessDelete.Text = "削除";
            sessDelete.UseVisualStyleBackColor = true;
            sessDelete.Click += sessDelete_Click;
            // 
            // sessCheck
            // 
            sessCheck.Location = new Point(20, 49);
            sessCheck.Name = "sessCheck";
            sessCheck.Size = new Size(200, 58);
            sessCheck.TabIndex = 5;
            sessCheck.Text = "確認";
            sessCheck.UseVisualStyleBackColor = true;
            sessCheck.Click += sessCheck_Click;
            // 
            // uxCommand
            // 
            uxCommand.Location = new Point(53, 265);
            uxCommand.Multiline = true;
            uxCommand.Name = "uxCommand";
            uxCommand.ReadOnly = true;
            uxCommand.Size = new Size(1212, 343);
            uxCommand.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, SettingSToolStripMenuItem, versionVToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1300, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cnIPIToolStripMenuItem, cnDODToolStripMenuItem, sessCheckCToolStripMenuItem, sessDeleteEToolStripMenuItem, pcRebootRToolStripMenuItem, closeWToolStripMenuItem });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(82, 24);
            ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // cnIPIToolStripMenuItem
            // 
            cnIPIToolStripMenuItem.Name = "cnIPIToolStripMenuItem";
            cnIPIToolStripMenuItem.Size = new Size(171, 26);
            cnIPIToolStripMenuItem.Text = "接続IP(&I)";
            cnIPIToolStripMenuItem.Click += cnIPIToolStripMenuItem_Click;
            // 
            // cnDODToolStripMenuItem
            // 
            cnDODToolStripMenuItem.Name = "cnDODToolStripMenuItem";
            cnDODToolStripMenuItem.Size = new Size(171, 26);
            cnDODToolStripMenuItem.Text = "接続DO(&D)";
            cnDODToolStripMenuItem.Click += cnDODToolStripMenuItem_Click;
            // 
            // sessCheckCToolStripMenuItem
            // 
            sessCheckCToolStripMenuItem.Name = "sessCheckCToolStripMenuItem";
            sessCheckCToolStripMenuItem.Size = new Size(171, 26);
            sessCheckCToolStripMenuItem.Text = "接続確認(&C)";
            sessCheckCToolStripMenuItem.Click += sessCheckCToolStripMenuItem_Click;
            // 
            // sessDeleteEToolStripMenuItem
            // 
            sessDeleteEToolStripMenuItem.Name = "sessDeleteEToolStripMenuItem";
            sessDeleteEToolStripMenuItem.Size = new Size(171, 26);
            sessDeleteEToolStripMenuItem.Text = "接続削除(&E)";
            sessDeleteEToolStripMenuItem.Click += sessDeleteEToolStripMenuItem_Click;
            // 
            // pcRebootRToolStripMenuItem
            // 
            pcRebootRToolStripMenuItem.Name = "pcRebootRToolStripMenuItem";
            pcRebootRToolStripMenuItem.Size = new Size(171, 26);
            pcRebootRToolStripMenuItem.Text = "再起動(R)";
            pcRebootRToolStripMenuItem.Click += pcRebootRToolStripMenuItem_Click;
            // 
            // closeWToolStripMenuItem
            // 
            closeWToolStripMenuItem.Name = "closeWToolStripMenuItem";
            closeWToolStripMenuItem.Size = new Size(171, 26);
            closeWToolStripMenuItem.Text = "閉じる(&W)";
            closeWToolStripMenuItem.Click += closeWToolStripMenuItem_Click;
            // 
            // SettingSToolStripMenuItem
            // 
            SettingSToolStripMenuItem.Name = "SettingSToolStripMenuItem";
            SettingSToolStripMenuItem.Size = new Size(71, 24);
            SettingSToolStripMenuItem.Text = "設定(&S)";
            SettingSToolStripMenuItem.Click += SettingSToolStripMenuItem_Click;
            // 
            // versionVToolStripMenuItem
            // 
            versionVToolStripMenuItem.Name = "versionVToolStripMenuItem";
            versionVToolStripMenuItem.Size = new Size(126, 24);
            versionVToolStripMenuItem.Text = "バージョン情報(&V)";
            versionVToolStripMenuItem.Click += versionVToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 637);
            Controls.Add(uxCommand);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(setting);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "ねとぺい";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox uxCommand;
        private Button sessDelete;
        private Button btnReboot;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem cnIPIToolStripMenuItem;
        private ToolStripMenuItem cnDODToolStripMenuItem;
        private ToolStripMenuItem sessCheckCToolStripMenuItem;
        private ToolStripMenuItem sessDeleteEToolStripMenuItem;
        private ToolStripMenuItem pcRebootRToolStripMenuItem;
        private ToolStripMenuItem closeWToolStripMenuItem;
        private ToolStripMenuItem SettingSToolStripMenuItem;
        private ToolStripMenuItem versionVToolStripMenuItem;
    }
}
