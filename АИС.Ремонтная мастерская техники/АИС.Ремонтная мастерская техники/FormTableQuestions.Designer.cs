namespace АИС.Ремонтная_мастерская_техники
{
    partial class FormTableQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTableQuestions));
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.BackColor = System.Drawing.Color.Linen;
            this.ButtonRefresh.Location = new System.Drawing.Point(12, 396);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(108, 48);
            this.ButtonRefresh.TabIndex = 11;
            this.ButtonRefresh.Text = "Обновить";
            this.ButtonRefresh.UseVisualStyleBackColor = false;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.Linen;
            this.ButtonBack.Location = new System.Drawing.Point(460, 396);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(114, 42);
            this.ButtonBack.TabIndex = 10;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(12, 18);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.Size = new System.Drawing.Size(565, 366);
            this.DataGrid.TabIndex = 12;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            // 
            // LabelInfo
            // 
            this.LabelInfo.AutoSize = true;
            this.LabelInfo.Location = new System.Drawing.Point(126, 396);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(328, 13);
            this.LabelInfo.TabIndex = 18;
            this.LabelInfo.Text = "Для удаления записи нажмите на нужную ячейку и нажмин ОК";
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(262, 421);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(39, 13);
            this.LabelSearch.TabIndex = 17;
            this.LabelSearch.Text = "Посик";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(307, 418);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(136, 20);
            this.SearchTextBox.TabIndex = 16;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // FormTableQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(581, 449);
            this.Controls.Add(this.LabelInfo);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.ButtonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTableQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС Ремонтная мастерская техники ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTableQuestions_FormClosed);
            this.Load += new System.EventHandler(this.FormTableQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Label LabelInfo;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.TextBox SearchTextBox;
    }
}