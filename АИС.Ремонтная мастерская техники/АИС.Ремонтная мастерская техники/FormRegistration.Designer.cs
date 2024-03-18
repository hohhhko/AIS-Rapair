namespace АИС.Ремонтная_мастерская_техники
{
    partial class FormRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.ButtonRegistrtion = new System.Windows.Forms.Button();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelPassWord = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.Datetime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(67, 80);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(142, 20);
            this.TextBoxLogin.TabIndex = 0;
            // 
            // ButtonRegistrtion
            // 
            this.ButtonRegistrtion.BackColor = System.Drawing.Color.Linen;
            this.ButtonRegistrtion.Location = new System.Drawing.Point(172, 190);
            this.ButtonRegistrtion.Name = "ButtonRegistrtion";
            this.ButtonRegistrtion.Size = new System.Drawing.Size(119, 53);
            this.ButtonRegistrtion.TabIndex = 1;
            this.ButtonRegistrtion.Text = "Регистрация ";
            this.ButtonRegistrtion.UseVisualStyleBackColor = false;
            this.ButtonRegistrtion.Click += new System.EventHandler(this.ButtonRegistrtion_Click);
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Location = new System.Drawing.Point(264, 80);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.Size = new System.Drawing.Size(142, 20);
            this.TextBoxPass.TabIndex = 2;
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.Linen;
            this.ButtonBack.Location = new System.Drawing.Point(26, 252);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonBack.Size = new System.Drawing.Size(107, 58);
            this.ButtonBack.TabIndex = 3;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(64, 53);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(38, 13);
            this.LabelLogin.TabIndex = 4;
            this.LabelLogin.Text = "Логин";
            // 
            // LabelPassWord
            // 
            this.LabelPassWord.AutoSize = true;
            this.LabelPassWord.Location = new System.Drawing.Point(261, 53);
            this.LabelPassWord.Name = "LabelPassWord";
            this.LabelPassWord.Size = new System.Drawing.Size(45, 13);
            this.LabelPassWord.TabIndex = 5;
            this.LabelPassWord.Text = "Пароль";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(67, 128);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(142, 20);
            this.TextBoxName.TabIndex = 6;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(64, 111);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(29, 13);
            this.LabelName.TabIndex = 7;
            this.LabelName.Text = "Имя";
            // 
            // Datetime
            // 
            this.Datetime.Location = new System.Drawing.Point(264, 128);
            this.Datetime.Name = "Datetime";
            this.Datetime.Size = new System.Drawing.Size(200, 20);
            this.Datetime.TabIndex = 8;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(519, 333);
            this.Controls.Add(this.Datetime);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelPassWord);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.ButtonRegistrtion);
            this.Controls.Add(this.TextBoxLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС Ремонтная мастерская техники ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegistration_FormClosed);
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.Button ButtonRegistrtion;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPassWord;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.DateTimePicker Datetime;
    }
}