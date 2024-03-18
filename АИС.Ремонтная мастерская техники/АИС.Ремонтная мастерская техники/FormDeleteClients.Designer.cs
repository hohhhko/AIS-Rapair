
namespace АИС.Ремонтная_мастерская_техники
{
    partial class FormDeleteClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeleteClients));
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.TextBoxlogin = new System.Windows.Forms.TextBox();
            this.TextBoxPassWord = new System.Windows.Forms.TextBox();
            this.LabelPassWord = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.Linen;
            this.ButtonDelete.Location = new System.Drawing.Point(285, 70);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(79, 58);
            this.ButtonDelete.TabIndex = 0;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(46, 42);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(44, 13);
            this.LabelLogin.TabIndex = 1;
            this.LabelLogin.Text = "Лоигин";
            // 
            // TextBoxlogin
            // 
            this.TextBoxlogin.Location = new System.Drawing.Point(49, 70);
            this.TextBoxlogin.Name = "TextBoxlogin";
            this.TextBoxlogin.Size = new System.Drawing.Size(122, 20);
            this.TextBoxlogin.TabIndex = 2;
            // 
            // TextBoxPassWord
            // 
            this.TextBoxPassWord.Location = new System.Drawing.Point(49, 125);
            this.TextBoxPassWord.Name = "TextBoxPassWord";
            this.TextBoxPassWord.Size = new System.Drawing.Size(133, 20);
            this.TextBoxPassWord.TabIndex = 3;
            // 
            // LabelPassWord
            // 
            this.LabelPassWord.AutoSize = true;
            this.LabelPassWord.Location = new System.Drawing.Point(46, 100);
            this.LabelPassWord.Name = "LabelPassWord";
            this.LabelPassWord.Size = new System.Drawing.Size(45, 13);
            this.LabelPassWord.TabIndex = 4;
            this.LabelPassWord.Text = "Пароль";
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.Linen;
            this.ButtonBack.Location = new System.Drawing.Point(285, 187);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(75, 29);
            this.ButtonBack.TabIndex = 5;
            this.ButtonBack.Text = "Вернутся";
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // FormDeleteClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(379, 228);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.LabelPassWord);
            this.Controls.Add(this.TextBoxPassWord);
            this.Controls.Add(this.TextBoxlogin);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.ButtonDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDeleteClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС.Ремонтная мастерская техники ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDeleteClients_FormClosed);
            this.Load += new System.EventHandler(this.FormDeleteClients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.TextBox TextBoxlogin;
        private System.Windows.Forms.TextBox TextBoxPassWord;
        private System.Windows.Forms.Label LabelPassWord;
        private System.Windows.Forms.Button ButtonBack;
    }
}