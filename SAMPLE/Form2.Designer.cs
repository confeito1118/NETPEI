namespace SAMPLE
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            IP = new TextBox();
            setting = new Button();
            label1 = new Label();
            DO = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // IP
            // 
            IP.Location = new Point(127, 41);
            IP.Name = "IP";
            IP.Size = new Size(300, 27);
            IP.TabIndex = 0;
            // 
            // setting
            // 
            setting.Location = new Point(387, 162);
            setting.Name = "setting";
            setting.Size = new Size(94, 29);
            setting.TabIndex = 1;
            setting.Text = "設定";
            setting.UseVisualStyleBackColor = true;
            setting.Click += setting_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 41);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 2;
            label1.Text = "IPアドレス：";
            // 
            // DO
            // 
            DO.Location = new Point(127, 88);
            DO.Name = "DO";
            DO.Size = new Size(300, 27);
            DO.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 88);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "ドメイン：";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 219);
            Controls.Add(label2);
            Controls.Add(DO);
            Controls.Add(label1);
            Controls.Add(setting);
            Controls.Add(IP);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "ねとぺい 設定画面";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IP;
        private Button setting;
        private Label label1;
        private TextBox DO;
        private Label label2;
    }
}