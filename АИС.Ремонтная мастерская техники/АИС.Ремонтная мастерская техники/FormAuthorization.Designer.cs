
namespace АИС.Ремонтная_мастерская_техники
{
    partial class FormAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            this.LabelWelcome = new System.Windows.Forms.Label();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonDeleteClient = new System.Windows.Forms.Button();
            this.ButtonRegistationClient = new System.Windows.Forms.Button();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.LabelPass = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.CheckBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelWelcome
            // 
            this.LabelWelcome.AutoSize = true;
            this.LabelWelcome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LabelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelWelcome.Location = new System.Drawing.Point(123, 29);
            this.LabelWelcome.Name = "LabelWelcome";
            this.LabelWelcome.Size = new System.Drawing.Size(393, 20);
            this.LabelWelcome.TabIndex = 0;
            this.LabelWelcome.Text = "Пожалуйста войдите или зарегистрируйтесь\r\n";
            // 
            // ButtonNext
            // 
            this.ButtonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNext.Location = new System.Drawing.Point(499, 108);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(131, 111);
            this.ButtonNext.TabIndex = 1;
            this.ButtonNext.Text = "ВОЙТИ";
            this.ButtonNext.UseVisualStyleBackColor = false;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonDeleteClient
            // 
            this.ButtonDeleteClient.Location = new System.Drawing.Point(234, 261);
            this.ButtonDeleteClient.Name = "ButtonDeleteClient";
            this.ButtonDeleteClient.Size = new System.Drawing.Size(168, 60);
            this.ButtonDeleteClient.TabIndex = 2;
            this.ButtonDeleteClient.Text = "Удалить аккаунт ";
            this.ButtonDeleteClient.UseVisualStyleBackColor = true;
            this.ButtonDeleteClient.Click += new System.EventHandler(this.ButtonDeleteClient_Click);
            // 
            // ButtonRegistationClient
            // 
            this.ButtonRegistationClient.Location = new System.Drawing.Point(45, 261);
            this.ButtonRegistationClient.Name = "ButtonRegistationClient";
            this.ButtonRegistationClient.Size = new System.Drawing.Size(168, 60);
            this.ButtonRegistationClient.TabIndex = 3;
            this.ButtonRegistationClient.Text = "Регистрация ";
            this.ButtonRegistationClient.UseVisualStyleBackColor = true;
            this.ButtonRegistationClient.Click += new System.EventHandler(this.ButtonRegistationClient_Click);
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Location = new System.Drawing.Point(45, 183);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.Size = new System.Drawing.Size(196, 20);
            this.TextBoxPass.TabIndex = 4;
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(45, 119);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(196, 20);
            this.TextBoxLogin.TabIndex = 5;
            // 
            // LabelPass
            // 
            this.LabelPass.AutoSize = true;
            this.LabelPass.Location = new System.Drawing.Point(42, 158);
            this.LabelPass.Name = "LabelPass";
            this.LabelPass.Size = new System.Drawing.Size(45, 13);
            this.LabelPass.TabIndex = 6;
            this.LabelPass.Text = "Пароль";
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(42, 91);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(38, 13);
            this.LabelLogin.TabIndex = 7;
            this.LabelLogin.Text = "Логин";
            // 
            // CheckBoxShowPassword
            // 
            this.CheckBoxShowPassword.AutoSize = true;
            this.CheckBoxShowPassword.Location = new System.Drawing.Point(256, 183);
            this.CheckBoxShowPassword.Name = "CheckBoxShowPassword";
            this.CheckBoxShowPassword.Size = new System.Drawing.Size(123, 17);
            this.CheckBoxShowPassword.TabIndex = 8;
            this.CheckBoxShowPassword.Text = "Показать пароль ?";
            this.CheckBoxShowPassword.UseVisualStyleBackColor = true;
            this.CheckBoxShowPassword.CheckedChanged += new System.EventHandler(this.CheckBoxShowPassword_CheckedChanged);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(45, 359);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(168, 53);
            this.ButtonBack.TabIndex = 9;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(669, 426);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.CheckBoxShowPassword);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.LabelPass);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.ButtonRegistationClient);
            this.Controls.Add(this.ButtonDeleteClient);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.LabelWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС Ремонтная мастерская техники ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAuthorization_FormClosing);
            this.Load += new System.EventHandler(this.FormAuthorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelWelcome;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonDeleteClient;
        private System.Windows.Forms.Button ButtonRegistationClient;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.Label LabelPass;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.CheckBox CheckBoxShowPassword;
        private System.Windows.Forms.Button ButtonBack;
    }
}