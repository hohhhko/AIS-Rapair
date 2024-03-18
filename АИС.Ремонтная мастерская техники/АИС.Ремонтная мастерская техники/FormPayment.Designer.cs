namespace АИС.Ремонтная_мастерская_техники
{
    partial class FormPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            this.LabelCardCode = new System.Windows.Forms.Label();
            this.ButtonPay = new System.Windows.Forms.Button();
            this.ButtonCancelOrder = new System.Windows.Forms.Button();
            this.TextBoxCardCode = new System.Windows.Forms.TextBox();
            this.TextBoxDate = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxCVC = new System.Windows.Forms.TextBox();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelCVC = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelCardCode
            // 
            this.LabelCardCode.AutoSize = true;
            this.LabelCardCode.Location = new System.Drawing.Point(27, 108);
            this.LabelCardCode.Name = "LabelCardCode";
            this.LabelCardCode.Size = new System.Drawing.Size(60, 13);
            this.LabelCardCode.TabIndex = 0;
            this.LabelCardCode.Text = "Код карты";
            // 
            // ButtonPay
            // 
            this.ButtonPay.BackColor = System.Drawing.Color.Linen;
            this.ButtonPay.Location = new System.Drawing.Point(403, 122);
            this.ButtonPay.Name = "ButtonPay";
            this.ButtonPay.Size = new System.Drawing.Size(91, 79);
            this.ButtonPay.TabIndex = 1;
            this.ButtonPay.Text = "Оплатить";
            this.ButtonPay.UseVisualStyleBackColor = false;
            this.ButtonPay.Click += new System.EventHandler(this.ButtonPay_Click);
            // 
            // ButtonCancelOrder
            // 
            this.ButtonCancelOrder.BackColor = System.Drawing.Color.Linen;
            this.ButtonCancelOrder.Location = new System.Drawing.Point(30, 255);
            this.ButtonCancelOrder.Name = "ButtonCancelOrder";
            this.ButtonCancelOrder.Size = new System.Drawing.Size(100, 38);
            this.ButtonCancelOrder.TabIndex = 2;
            this.ButtonCancelOrder.Text = "Отменить заказ";
            this.ButtonCancelOrder.UseVisualStyleBackColor = false;
            this.ButtonCancelOrder.Click += new System.EventHandler(this.ButtonCancelOrder_Click);
            // 
            // TextBoxCardCode
            // 
            this.TextBoxCardCode.Location = new System.Drawing.Point(30, 139);
            this.TextBoxCardCode.Name = "TextBoxCardCode";
            this.TextBoxCardCode.Size = new System.Drawing.Size(140, 20);
            this.TextBoxCardCode.TabIndex = 3;
            // 
            // TextBoxDate
            // 
            this.TextBoxDate.Location = new System.Drawing.Point(192, 139);
            this.TextBoxDate.Name = "TextBoxDate";
            this.TextBoxDate.Size = new System.Drawing.Size(147, 20);
            this.TextBoxDate.TabIndex = 4;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(223, 49);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(140, 20);
            this.TextBoxName.TabIndex = 5;
            // 
            // TextBoxCVC
            // 
            this.TextBoxCVC.Location = new System.Drawing.Point(70, 197);
            this.TextBoxCVC.Name = "TextBoxCVC";
            this.TextBoxCVC.Size = new System.Drawing.Size(147, 20);
            this.TextBoxCVC.TabIndex = 6;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(189, 108);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(83, 13);
            this.LabelDate.TabIndex = 7;
            this.LabelDate.Text = "Дата действия";
            // 
            // LabelCVC
            // 
            this.LabelCVC.AutoSize = true;
            this.LabelCVC.Location = new System.Drawing.Point(67, 174);
            this.LabelCVC.Name = "LabelCVC";
            this.LabelCVC.Size = new System.Drawing.Size(28, 13);
            this.LabelCVC.TabIndex = 8;
            this.LabelCVC.Text = "CVC";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(21, 52);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(196, 13);
            this.LabelName.TabIndex = 9;
            this.LabelName.Text = "Имя которое вы указывали в заказе";
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(517, 311);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelCVC);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.TextBoxCVC);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxDate);
            this.Controls.Add(this.TextBoxCardCode);
            this.Controls.Add(this.ButtonCancelOrder);
            this.Controls.Add(this.ButtonPay);
            this.Controls.Add(this.LabelCardCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС Ремонтная мастерская техники ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPayment_FormClosed);
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCardCode;
        private System.Windows.Forms.Button ButtonPay;
        private System.Windows.Forms.Button ButtonCancelOrder;
        private System.Windows.Forms.TextBox TextBoxCardCode;
        private System.Windows.Forms.TextBox TextBoxDate;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxCVC;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelCVC;
        private System.Windows.Forms.Label LabelName;
    }
}