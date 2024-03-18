namespace АИС.Ремонтная_мастерская_техники
{
    partial class FormRegistrationWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrationWorker));
            this.ButtonRegistation = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ComboBoxSpecalization = new System.Windows.Forms.ComboBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.TextBoxDocuments = new System.Windows.Forms.TextBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelPassWord = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelSpecalization = new System.Windows.Forms.Label();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.LabelSallary = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.TextBoxSallary = new System.Windows.Forms.TextBox();
            this.LabelDocuments = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonRegistation
            // 
            this.ButtonRegistation.BackColor = System.Drawing.Color.Linen;
            this.ButtonRegistation.Location = new System.Drawing.Point(462, 138);
            this.ButtonRegistation.Name = "ButtonRegistation";
            this.ButtonRegistation.Size = new System.Drawing.Size(110, 39);
            this.ButtonRegistation.TabIndex = 0;
            this.ButtonRegistation.Text = "Зарегистрировать";
            this.ButtonRegistation.UseVisualStyleBackColor = false;
            this.ButtonRegistation.Click += new System.EventHandler(this.ButtonRegistation_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.Linen;
            this.ButtonBack.Location = new System.Drawing.Point(12, 261);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(97, 36);
            this.ButtonBack.TabIndex = 1;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ComboBoxSpecalization
            // 
            this.ComboBoxSpecalization.FormattingEnabled = true;
            this.ComboBoxSpecalization.Items.AddRange(new object[] {
            "Генеральный директор",
            "Зам.Генерального директора",
            "Мастер по ремонтным работам",
            "Кассир"});
            this.ComboBoxSpecalization.Location = new System.Drawing.Point(235, 150);
            this.ComboBoxSpecalization.Name = "ComboBoxSpecalization";
            this.ComboBoxSpecalization.Size = new System.Drawing.Size(191, 21);
            this.ComboBoxSpecalization.TabIndex = 2;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(12, 115);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(161, 20);
            this.TextBoxName.TabIndex = 3;
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Location = new System.Drawing.Point(12, 157);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(158, 20);
            this.TextBoxPhone.TabIndex = 4;
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(15, 60);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(161, 20);
            this.TextBoxLogin.TabIndex = 5;
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Location = new System.Drawing.Point(235, 89);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.Size = new System.Drawing.Size(191, 20);
            this.TextBoxPass.TabIndex = 6;
            // 
            // TextBoxDocuments
            // 
            this.TextBoxDocuments.Location = new System.Drawing.Point(235, 206);
            this.TextBoxDocuments.Name = "TextBoxDocuments";
            this.TextBoxDocuments.Size = new System.Drawing.Size(191, 20);
            this.TextBoxDocuments.TabIndex = 7;
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(15, 44);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(38, 13);
            this.LabelLogin.TabIndex = 8;
            this.LabelLogin.Text = "Логин";
            // 
            // LabelPassWord
            // 
            this.LabelPassWord.AutoSize = true;
            this.LabelPassWord.Location = new System.Drawing.Point(232, 60);
            this.LabelPassWord.Name = "LabelPassWord";
            this.LabelPassWord.Size = new System.Drawing.Size(45, 13);
            this.LabelPassWord.TabIndex = 9;
            this.LabelPassWord.Text = "Пароль";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(9, 92);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(79, 13);
            this.LabelName.TabIndex = 10;
            this.LabelName.Text = "Имя Рабочего";
            // 
            // LabelSpecalization
            // 
            this.LabelSpecalization.AutoSize = true;
            this.LabelSpecalization.Location = new System.Drawing.Point(232, 123);
            this.LabelSpecalization.Name = "LabelSpecalization";
            this.LabelSpecalization.Size = new System.Drawing.Size(85, 13);
            this.LabelSpecalization.TabIndex = 11;
            this.LabelSpecalization.Text = "Специальность";
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Location = new System.Drawing.Point(9, 138);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(58, 13);
            this.LabelNumber.TabIndex = 12;
            this.LabelNumber.Text = "Телеофон";
            // 
            // LabelSallary
            // 
            this.LabelSallary.AutoSize = true;
            this.LabelSallary.Location = new System.Drawing.Point(12, 187);
            this.LabelSallary.Name = "LabelSallary";
            this.LabelSallary.Size = new System.Drawing.Size(61, 13);
            this.LabelSallary.TabIndex = 13;
            this.LabelSallary.Text = "Зараплата";
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(235, 21);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(200, 20);
            this.DateTime.TabIndex = 14;
            // 
            // TextBoxSallary
            // 
            this.TextBoxSallary.Location = new System.Drawing.Point(12, 206);
            this.TextBoxSallary.Name = "TextBoxSallary";
            this.TextBoxSallary.Size = new System.Drawing.Size(158, 20);
            this.TextBoxSallary.TabIndex = 15;
            // 
            // LabelDocuments
            // 
            this.LabelDocuments.AutoSize = true;
            this.LabelDocuments.Location = new System.Drawing.Point(232, 187);
            this.LabelDocuments.Name = "LabelDocuments";
            this.LabelDocuments.Size = new System.Drawing.Size(66, 13);
            this.LabelDocuments.TabIndex = 16;
            this.LabelDocuments.Text = "Документы";
            // 
            // FormRegistrationWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(584, 312);
            this.Controls.Add(this.LabelDocuments);
            this.Controls.Add(this.TextBoxSallary);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.LabelSallary);
            this.Controls.Add(this.LabelNumber);
            this.Controls.Add(this.LabelSpecalization);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelPassWord);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.TextBoxDocuments);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.ComboBoxSpecalization);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonRegistation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistrationWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС Ремонтная мастерская техники ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegistrationWorker_FormClosed);
            this.Load += new System.EventHandler(this.FormRegistrationWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonRegistation;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.ComboBox ComboBoxSpecalization;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxPhone;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.TextBox TextBoxDocuments;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPassWord;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelSpecalization;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Label LabelSallary;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.TextBox TextBoxSallary;
        private System.Windows.Forms.Label LabelDocuments;
    }
}