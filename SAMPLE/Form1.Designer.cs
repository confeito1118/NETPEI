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
            SuspendLayout();
            // 
            // setting
            // 
            setting.Location = new Point(682, 56);
            setting.Name = "setting";
            setting.Size = new Size(94, 29);
            setting.TabIndex = 0;
            setting.Text = "設定";
            setting.UseVisualStyleBackColor = true;
            setting.Click += setting_Click;
            // 
            // qfileIP
            // 
            qfileIP.Location = new Point(52, 56);
            qfileIP.Name = "qfileIP";
            qfileIP.Size = new Size(94, 29);
            qfileIP.TabIndex = 1;
            qfileIP.Text = "button1";
            qfileIP.UseVisualStyleBackColor = true;
            qfileIP.Click += qfileIP_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(qfileIP);
            Controls.Add(setting);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button setting;
        private Button qfileIP;
    }
}
