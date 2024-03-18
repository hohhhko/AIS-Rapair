namespace АИС.Ремонтная_мастерская_техники
{
    partial class FormBankDetals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBankDetals));
            this.TextBoxCVC = new System.Windows.Forms.TextBox();
            this.TextBoxDate = new System.Windows.Forms.TextBox();
            this.TextBoxCardCode = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.ButtonChek = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.LabelCardCode = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelCVC = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxBallance = new System.Windows.Forms.TextBox();
            this.LabelBallance = new System.Windows.Forms.Label();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonInsertCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxCVC
            // 
            this.TextBoxCVC.Location = new System.Drawing.Point(299, 132);
            this.TextBoxCVC.Name = "TextBoxCVC";
            this.TextBoxCVC.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCVC.TabIndex = 0;
            // 
            // TextBoxDate
            // 
            this.TextBoxDate.Location = new System.Drawing.Point(301, 61);
            this.TextBoxDate.Name = "TextBoxDate";
            this.TextBoxDate.Size = new System.Drawing.Size(100, 20);
            this.TextBoxDate.TabIndex = 1;
            // 
            // TextBoxCardCode
            // 
            this.TextBoxCardCode.Location = new System.Drawing.Point(114, 61);
            this.TextBoxCardCode.Name = "TextBoxCardCode";
            this.TextBoxCardCode.Size = new System.Drawing.Size(163, 20);
            this.TextBoxCardCode.TabIndex = 2;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(114, 132);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(163, 20);
            this.TextBoxName.TabIndex = 4;
            // 
            // ButtonChek
            // 
            this.ButtonChek.BackColor = System.Drawing.Color.PaleGreen;
            this.ButtonChek.Location = new System.Drawing.Point(447, 42);
            this.ButtonChek.Name = "ButtonChek";
            this.ButtonChek.Size = new System.Drawing.Size(131, 57);
            this.ButtonChek.TabIndex = 5;
            this.ButtonChek.Text = "Проверить";
            this.ButtonChek.UseVisualStyleBackColor = false;
            this.ButtonChek.Click += new System.EventHandler(this.ButtonChek_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(37, 229);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(96, 58);
            this.ButtonBack.TabIndex = 6;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // LabelCardCode
            // 
            this.LabelCardCode.AutoSize = true;
            this.LabelCardCode.Location = new System.Drawing.Point(111, 33);
            this.LabelCardCode.Name = "LabelCardCode";
            this.LabelCardCode.Size = new System.Drawing.Size(63, 13);
            this.LabelCardCode.TabIndex = 7;
            this.LabelCardCode.Text = "Код карты ";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(298, 33);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(83, 13);
            this.LabelDate.TabIndex = 8;
            this.LabelDate.Text = "Дата действия";
            // 
            // LabelCVC
            // 
            this.LabelCVC.AutoSize = true;
            this.LabelCVC.Location = new System.Drawing.Point(298, 104);
            this.LabelCVC.Name = "LabelCVC";
            this.LabelCVC.Size = new System.Drawing.Size(28, 13);
            this.LabelCVC.TabIndex = 9;
            this.LabelCVC.Text = "CVC";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(111, 104);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(104, 13);
            this.LabelName.TabIndex = 10;
            this.LabelName.Text = "Имя с фамимлией ";
            // 
            // TextBoxBallance
            // 
            this.TextBoxBallance.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBoxBallance.Location = new System.Drawing.Point(221, 229);
            this.TextBoxBallance.Name = "TextBoxBallance";
            this.TextBoxBallance.Size = new System.Drawing.Size(160, 20);
            this.TextBoxBallance.TabIndex = 11;
            // 
            // LabelBallance
            // 
            this.LabelBallance.AutoSize = true;
            this.LabelBallance.Location = new System.Drawing.Point(218, 203);
            this.LabelBallance.Name = "LabelBallance";
            this.LabelBallance.Size = new System.Drawing.Size(155, 13);
            this.LabelBallance.TabIndex = 12;
            this.LabelBallance.Text = "Сумма пополнения балланса";
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.BackColor = System.Drawing.Color.LightGreen;
            this.ButtonUpdate.Location = new System.Drawing.Point(447, 113);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(131, 57);
            this.ButtonUpdate.TabIndex = 13;
            this.ButtonUpdate.Text = "Пополнить";
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonInsertCard
            // 
            this.ButtonInsertCard.BackColor = System.Drawing.Color.GreenYellow;
            this.ButtonInsertCard.Location = new System.Drawing.Point(447, 226);
            this.ButtonInsertCard.Name = "ButtonInsertCard";
            this.ButtonInsertCard.Size = new System.Drawing.Size(131, 51);
            this.ButtonInsertCard.TabIndex = 14;
            this.ButtonInsertCard.Text = "Добавить карту ";
            this.ButtonInsertCard.UseVisualStyleBackColor = false;
            this.ButtonInsertCard.Click += new System.EventHandler(this.ButtonInsertCard_Click);
            // 
            // FormBankDetals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(624, 331);
            this.Controls.Add(this.ButtonInsertCard);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.LabelBallance);
            this.Controls.Add(this.TextBoxBallance);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelCVC);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.LabelCardCode);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonChek);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxCardCode);
            this.Controls.Add(this.TextBoxDate);
            this.Controls.Add(this.TextBoxCVC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBankDetals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС Ремонтная мастерская техники ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBankDetals_FormClosed);
            this.Load += new System.EventHandler(this.FormBankDetals_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxCVC;
        private System.Windows.Forms.TextBox TextBoxDate;
        private System.Windows.Forms.TextBox TextBoxCardCode;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Button ButtonChek;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label LabelCardCode;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelCVC;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextBoxBallance;
        private System.Windows.Forms.Label LabelBallance;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonInsertCard;
    }
}