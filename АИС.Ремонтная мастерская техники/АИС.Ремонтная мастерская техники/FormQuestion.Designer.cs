namespace АИС.Ремонтная_мастерская_техники
{
    partial class FormQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuestion));
            this.ButtonQuestion = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.TextBoxQuestion = new System.Windows.Forms.TextBox();
            this.LabelFAQ = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelQuestion = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.TextBoxNumber = new System.Windows.Forms.TextBox();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonQuestion
            // 
            this.ButtonQuestion.BackColor = System.Drawing.Color.Linen;
            this.ButtonQuestion.Location = new System.Drawing.Point(585, 56);
            this.ButtonQuestion.Name = "ButtonQuestion";
            this.ButtonQuestion.Size = new System.Drawing.Size(106, 43);
            this.ButtonQuestion.TabIndex = 0;
            this.ButtonQuestion.Text = "Задать вопрос";
            this.ButtonQuestion.UseVisualStyleBackColor = false;
            this.ButtonQuestion.Click += new System.EventHandler(this.ButtonQuestion_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.Linen;
            this.ButtonBack.Location = new System.Drawing.Point(12, 197);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(97, 46);
            this.ButtonBack.TabIndex = 1;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // TextBoxQuestion
            // 
            this.TextBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxQuestion.Location = new System.Drawing.Point(109, 69);
            this.TextBoxQuestion.Name = "TextBoxQuestion";
            this.TextBoxQuestion.Size = new System.Drawing.Size(445, 20);
            this.TextBoxQuestion.TabIndex = 2;
            // 
            // LabelFAQ
            // 
            this.LabelFAQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFAQ.Location = new System.Drawing.Point(115, 103);
            this.LabelFAQ.Name = "LabelFAQ";
            this.LabelFAQ.Size = new System.Drawing.Size(360, 105);
            this.LabelFAQ.TabIndex = 3;
            this.LabelFAQ.Text = "Вопросы на которых не будет ответа:\r\n- касаемые доходов:\r\n- касаемые личной жизни" +
    " (возможны исключения):\r\n";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(109, 34);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(128, 20);
            this.TextBoxName.TabIndex = 4;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(106, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(29, 13);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "Имя";
            // 
            // LabelQuestion
            // 
            this.LabelQuestion.AutoSize = true;
            this.LabelQuestion.Location = new System.Drawing.Point(55, 71);
            this.LabelQuestion.Name = "LabelQuestion";
            this.LabelQuestion.Size = new System.Drawing.Size(44, 13);
            this.LabelQuestion.TabIndex = 6;
            this.LabelQuestion.Text = "Вопрос";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(491, 30);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 20);
            this.Date.TabIndex = 7;
            this.Date.Visible = false;
            // 
            // TextBoxNumber
            // 
            this.TextBoxNumber.Location = new System.Drawing.Point(258, 34);
            this.TextBoxNumber.Name = "TextBoxNumber";
            this.TextBoxNumber.Size = new System.Drawing.Size(133, 20);
            this.TextBoxNumber.TabIndex = 8;
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Location = new System.Drawing.Point(255, 9);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(93, 13);
            this.LabelNumber.TabIndex = 9;
            this.LabelNumber.Text = "Номер телефона";
            // 
            // FormQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(784, 260);
            this.Controls.Add(this.LabelNumber);
            this.Controls.Add(this.TextBoxNumber);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.LabelQuestion);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelFAQ);
            this.Controls.Add(this.TextBoxQuestion);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС Ремонтная мастерская техники";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQuestion_FormClosed);
            this.Load += new System.EventHandler(this.FormQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonQuestion;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.TextBox TextBoxQuestion;
        private System.Windows.Forms.Label LabelFAQ;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelQuestion;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.TextBox TextBoxNumber;
        private System.Windows.Forms.Label LabelNumber;
    }
}