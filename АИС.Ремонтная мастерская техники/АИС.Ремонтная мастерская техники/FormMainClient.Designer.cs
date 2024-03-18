namespace АИС.Ремонтная_мастерская_техники
{
    partial class FormMainClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainClient));
            this.ButtonOrder = new System.Windows.Forms.Button();
            this.ButtonQuestion = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonBankdetals = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonOrder
            // 
            this.ButtonOrder.BackColor = System.Drawing.Color.Linen;
            this.ButtonOrder.Location = new System.Drawing.Point(140, 75);
            this.ButtonOrder.Name = "ButtonOrder";
            this.ButtonOrder.Size = new System.Drawing.Size(177, 45);
            this.ButtonOrder.TabIndex = 1;
            this.ButtonOrder.Text = "Сделать заказ  ";
            this.ButtonOrder.UseVisualStyleBackColor = false;
            this.ButtonOrder.Click += new System.EventHandler(this.ButtonOrder_Click);
            // 
            // ButtonQuestion
            // 
            this.ButtonQuestion.BackColor = System.Drawing.Color.Linen;
            this.ButtonQuestion.Location = new System.Drawing.Point(188, 150);
            this.ButtonQuestion.Name = "ButtonQuestion";
            this.ButtonQuestion.Size = new System.Drawing.Size(169, 40);
            this.ButtonQuestion.TabIndex = 2;
            this.ButtonQuestion.Text = "Вопрсо по технкие ";
            this.ButtonQuestion.UseVisualStyleBackColor = false;
            this.ButtonQuestion.Click += new System.EventHandler(this.ButtonQuestion_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.Linen;
            this.ButtonBack.Location = new System.Drawing.Point(21, 273);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(126, 52);
            this.ButtonBack.TabIndex = 3;
            this.ButtonBack.Text = "Венрнутся назад ";
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonBankdetals
            // 
            this.ButtonBankdetals.BackColor = System.Drawing.Color.Linen;
            this.ButtonBankdetals.Location = new System.Drawing.Point(254, 209);
            this.ButtonBankdetals.Name = "ButtonBankdetals";
            this.ButtonBankdetals.Size = new System.Drawing.Size(164, 44);
            this.ButtonBankdetals.TabIndex = 4;
            this.ButtonBankdetals.Text = "Пополнить баланс или Добавить карту ";
            this.ButtonBankdetals.UseVisualStyleBackColor = false;
            this.ButtonBankdetals.Click += new System.EventHandler(this.ButtonBankdetals_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(123, 29);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(178, 13);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "Добро пожаловать пользователь";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormMainClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(586, 341);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.ButtonBankdetals);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonQuestion);
            this.Controls.Add(this.ButtonOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС Ремонтная мастерская техники ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMainClient_FormClosed);
            this.Load += new System.EventHandler(this.FormMainClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonOrder;
        private System.Windows.Forms.Button ButtonQuestion;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonBankdetals;
        private System.Windows.Forms.Label LabelName;
    }
}