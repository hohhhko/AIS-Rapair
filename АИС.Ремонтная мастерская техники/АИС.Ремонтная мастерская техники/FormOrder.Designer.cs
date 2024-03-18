namespace АИС.Ремонтная_мастерская_техники
{
    partial class FormOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.buttonBack = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxStuf = new System.Windows.Forms.TextBox();
            this.ListBoxOrders = new System.Windows.Forms.ListBox();
            this.LabelStuf = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelList = new System.Windows.Forms.Label();
            this.TextBoxSummOfOrders = new System.Windows.Forms.TextBox();
            this.LabelSummofOrder = new System.Windows.Forms.Label();
            this.ButtonCancelOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Linen;
            this.buttonBack.Location = new System.Drawing.Point(35, 307);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(89, 52);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.BackColor = System.Drawing.Color.LemonChiffon;
            this.ButtonNext.Location = new System.Drawing.Point(589, 128);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(137, 80);
            this.ButtonNext.TabIndex = 1;
            this.ButtonNext.Text = "Продорлжить";
            this.ButtonNext.UseVisualStyleBackColor = false;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(298, 58);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(200, 20);
            this.DateTime.TabIndex = 2;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(35, 128);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(164, 20);
            this.TextBoxName.TabIndex = 3;
            // 
            // TextBoxStuf
            // 
            this.TextBoxStuf.Location = new System.Drawing.Point(35, 200);
            this.TextBoxStuf.Name = "TextBoxStuf";
            this.TextBoxStuf.Size = new System.Drawing.Size(164, 20);
            this.TextBoxStuf.TabIndex = 4;
            // 
            // ListBoxOrders
            // 
            this.ListBoxOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBoxOrders.FormattingEnabled = true;
            this.ListBoxOrders.ItemHeight = 20;
            this.ListBoxOrders.Items.AddRange(new object[] {
            "Ремонт ",
            "Чистка ",
            "Диагностика ",
            "Копия "});
            this.ListBoxOrders.Location = new System.Drawing.Point(307, 128);
            this.ListBoxOrders.Name = "ListBoxOrders";
            this.ListBoxOrders.Size = new System.Drawing.Size(175, 84);
            this.ListBoxOrders.TabIndex = 5;
            this.ListBoxOrders.SelectedIndexChanged += new System.EventHandler(this.ListBoxOrders_SelectedIndexChanged);
            // 
            // LabelStuf
            // 
            this.LabelStuf.AutoSize = true;
            this.LabelStuf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelStuf.Location = new System.Drawing.Point(12, 161);
            this.LabelStuf.Name = "LabelStuf";
            this.LabelStuf.Size = new System.Drawing.Size(243, 18);
            this.LabelStuf.TabIndex = 6;
            this.LabelStuf.Text = "Введите нужный вам предмет";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(31, 95);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(164, 20);
            this.LabelName.TabIndex = 7;
            this.LabelName.Text = "Ведите ваше имя ";
            // 
            // LabelList
            // 
            this.LabelList.AutoSize = true;
            this.LabelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelList.Location = new System.Drawing.Point(295, 97);
            this.LabelList.Name = "LabelList";
            this.LabelList.Size = new System.Drawing.Size(203, 18);
            this.LabelList.TabIndex = 8;
            this.LabelList.Text = "Выбирите нужную услугу";
            // 
            // TextBoxSummOfOrders
            // 
            this.TextBoxSummOfOrders.Location = new System.Drawing.Point(263, 274);
            this.TextBoxSummOfOrders.Name = "TextBoxSummOfOrders";
            this.TextBoxSummOfOrders.Size = new System.Drawing.Size(235, 20);
            this.TextBoxSummOfOrders.TabIndex = 9;
            // 
            // LabelSummofOrder
            // 
            this.LabelSummofOrder.AutoSize = true;
            this.LabelSummofOrder.Location = new System.Drawing.Point(304, 246);
            this.LabelSummofOrder.Name = "LabelSummofOrder";
            this.LabelSummofOrder.Size = new System.Drawing.Size(77, 13);
            this.LabelSummofOrder.TabIndex = 10;
            this.LabelSummofOrder.Text = "Сумма услуги";
            // 
            // ButtonCancelOrder
            // 
            this.ButtonCancelOrder.BackColor = System.Drawing.Color.Salmon;
            this.ButtonCancelOrder.Location = new System.Drawing.Point(589, 225);
            this.ButtonCancelOrder.Name = "ButtonCancelOrder";
            this.ButtonCancelOrder.Size = new System.Drawing.Size(136, 69);
            this.ButtonCancelOrder.TabIndex = 11;
            this.ButtonCancelOrder.Text = "Удалить заказ";
            this.ButtonCancelOrder.UseVisualStyleBackColor = false;
            this.ButtonCancelOrder.Visible = false;
            this.ButtonCancelOrder.Click += new System.EventHandler(this.ButtonCancelOrder_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.ButtonCancelOrder);
            this.Controls.Add(this.LabelSummofOrder);
            this.Controls.Add(this.TextBoxSummOfOrders);
            this.Controls.Add(this.LabelList);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelStuf);
            this.Controls.Add(this.ListBoxOrders);
            this.Controls.Add(this.TextBoxStuf);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС Ремонтная мастерская техники ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOrder_FormClosed);
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxStuf;
        private System.Windows.Forms.ListBox ListBoxOrders;
        private System.Windows.Forms.Label LabelStuf;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelList;
        private System.Windows.Forms.TextBox TextBoxSummOfOrders;
        private System.Windows.Forms.Label LabelSummofOrder;
        public System.Windows.Forms.Button ButtonCancelOrder;
    }
}