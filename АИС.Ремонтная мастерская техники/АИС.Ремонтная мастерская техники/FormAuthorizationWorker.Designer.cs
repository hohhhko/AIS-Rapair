
namespace АИС.Ремонтная_мастерская_техники
{
    partial class FormAuthorizationWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorizationWorker));
            this.CheckBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelPassWord = new System.Windows.Forms.Label();
            this.TextBoxlogin = new System.Windows.Forms.TextBox();
            this.TextBoxPassWord = new System.Windows.Forms.TextBox();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckBoxShowPassword
            // 
            this.CheckBoxShowPassword.AutoSize = true;
            this.CheckBoxShowPassword.Location = new System.Drawing.Point(233, 120);
            this.CheckBoxShowPassword.Name = "CheckBoxShowPassword";
            this.CheckBoxShowPassword.Size = new System.Drawing.Size(123, 17);
            this.CheckBoxShowPassword.TabIndex = 13;
            this.CheckBoxShowPassword.Text = "Показать пароль ?";
            this.CheckBoxShowPassword.UseVisualStyleBackColor = true;
            this.CheckBoxShowPassword.CheckedChanged += new System.EventHandler(this.CheckBoxShowPassword_CheckedChanged);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(32, 40);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(38, 13);
            this.LabelLogin.TabIndex = 12;
            this.LabelLogin.Text = "Логин";
            // 
            // LabelPassWord
            // 
            this.LabelPassWord.AutoSize = true;
            this.LabelPassWord.Location = new System.Drawing.Point(253, 51);
            this.LabelPassWord.Name = "LabelPassWord";
            this.LabelPassWord.Size = new System.Drawing.Size(45, 13);
            this.LabelPassWord.TabIndex = 11;
            this.LabelPassWord.Text = "Пароль";
            // 
            // TextBoxlogin
            // 
            this.TextBoxlogin.Location = new System.Drawing.Point(12, 76);
            this.TextBoxlogin.Name = "TextBoxlogin";
            this.TextBoxlogin.Size = new System.Drawing.Size(196, 20);
            this.TextBoxlogin.TabIndex = 10;
            // 
            // TextBoxPassWord
            // 
            this.TextBoxPassWord.Location = new System.Drawing.Point(233, 76);
            this.TextBoxPassWord.Name = "TextBoxPassWord";
            this.TextBoxPassWord.Size = new System.Drawing.Size(196, 20);
            this.TextBoxPassWord.TabIndex = 9;
            // 
            // ButtonNext
            // 
            this.ButtonNext.BackColor = System.Drawing.Color.SandyBrown;
            this.ButtonNext.Location = new System.Drawing.Point(429, 111);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(110, 33);
            this.ButtonNext.TabIndex = 14;
            this.ButtonNext.Text = "Войти";
            this.ButtonNext.UseVisualStyleBackColor = false;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.Linen;
            this.ButtonBack.Location = new System.Drawing.Point(22, 163);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(103, 44);
            this.ButtonBack.TabIndex = 15;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click_1);
            // 
            // FormAuthorizationWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(551, 228);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.CheckBoxShowPassword);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.LabelPassWord);
            this.Controls.Add(this.TextBoxlogin);
            this.Controls.Add(this.TextBoxPassWord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAuthorizationWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС Ремонтная мастерская техники ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAuthorizationWorker_FormClosed);
            this.Load += new System.EventHandler(this.FormAuthorizationWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBoxShowPassword;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPassWord;
        private System.Windows.Forms.TextBox TextBoxlogin;
        private System.Windows.Forms.TextBox TextBoxPassWord;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonBack;
    }
}