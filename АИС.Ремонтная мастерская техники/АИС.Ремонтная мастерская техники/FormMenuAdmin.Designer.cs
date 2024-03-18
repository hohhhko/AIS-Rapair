
namespace АИС.Ремонтная_мастерская_техники
{
    partial class FormMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuAdmin));
            this.ButtonOrder = new System.Windows.Forms.Button();
            this.ButtonQuestion = new System.Windows.Forms.Button();
            this.ButtonTrashCan = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.LabelHello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonOrder
            // 
            this.ButtonOrder.BackColor = System.Drawing.Color.Linen;
            this.ButtonOrder.Location = new System.Drawing.Point(226, 105);
            this.ButtonOrder.Name = "ButtonOrder";
            this.ButtonOrder.Size = new System.Drawing.Size(168, 60);
            this.ButtonOrder.TabIndex = 4;
            this.ButtonOrder.Text = "Заказы ";
            this.ButtonOrder.UseVisualStyleBackColor = false;
            this.ButtonOrder.Click += new System.EventHandler(this.ButtonOrder_Click);
            // 
            // ButtonQuestion
            // 
            this.ButtonQuestion.BackColor = System.Drawing.Color.Linen;
            this.ButtonQuestion.Location = new System.Drawing.Point(24, 105);
            this.ButtonQuestion.Name = "ButtonQuestion";
            this.ButtonQuestion.Size = new System.Drawing.Size(168, 60);
            this.ButtonQuestion.TabIndex = 5;
            this.ButtonQuestion.Text = "Вопросы";
            this.ButtonQuestion.UseVisualStyleBackColor = false;
            this.ButtonQuestion.Click += new System.EventHandler(this.ButtonQuestion_Click);
            // 
            // ButtonTrashCan
            // 
            this.ButtonTrashCan.BackColor = System.Drawing.Color.Linen;
            this.ButtonTrashCan.Location = new System.Drawing.Point(429, 105);
            this.ButtonTrashCan.Name = "ButtonTrashCan";
            this.ButtonTrashCan.Size = new System.Drawing.Size(168, 60);
            this.ButtonTrashCan.TabIndex = 7;
            this.ButtonTrashCan.Text = "Корзина";
            this.ButtonTrashCan.UseVisualStyleBackColor = false;
            this.ButtonTrashCan.Click += new System.EventHandler(this.ButtonTrashCan_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.Crimson;
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(12, 212);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(95, 43);
            this.ButtonBack.TabIndex = 8;
            this.ButtonBack.Text = "ВЫЙТИ";
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // LabelHello
            // 
            this.LabelHello.AutoSize = true;
            this.LabelHello.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LabelHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelHello.Location = new System.Drawing.Point(185, 35);
            this.LabelHello.Name = "LabelHello";
            this.LabelHello.Size = new System.Drawing.Size(253, 20);
            this.LabelHello.TabIndex = 10;
            this.LabelHello.Text = "Главное меню разработчика";
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(629, 268);
            this.Controls.Add(this.LabelHello);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonTrashCan);
            this.Controls.Add(this.ButtonQuestion);
            this.Controls.Add(this.ButtonOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС Ремонтная мастерская техники ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenuAdmin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonOrder;
        private System.Windows.Forms.Button ButtonQuestion;
        private System.Windows.Forms.Button ButtonTrashCan;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label LabelHello;
    }
}