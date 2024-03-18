namespace АИС.Ремонтная_мастерская_техники
{
    partial class FormTableOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTableOrders));
            this.ButtonBackAdmin = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.ButtonBackWorker = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.LabelInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBackAdmin
            // 
            this.ButtonBackAdmin.BackColor = System.Drawing.Color.Linen;
            this.ButtonBackAdmin.Location = new System.Drawing.Point(447, 389);
            this.ButtonBackAdmin.Name = "ButtonBackAdmin";
            this.ButtonBackAdmin.Size = new System.Drawing.Size(125, 48);
            this.ButtonBackAdmin.TabIndex = 8;
            this.ButtonBackAdmin.Text = "Назад";
            this.ButtonBackAdmin.UseVisualStyleBackColor = false;
            this.ButtonBackAdmin.Click += new System.EventHandler(this.ButtonBackAdmin_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(12, 12);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.Size = new System.Drawing.Size(560, 366);
            this.DataGrid.TabIndex = 10;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            // 
            // ButtonBackWorker
            // 
            this.ButtonBackWorker.BackColor = System.Drawing.Color.Linen;
            this.ButtonBackWorker.Location = new System.Drawing.Point(447, 390);
            this.ButtonBackWorker.Name = "ButtonBackWorker";
            this.ButtonBackWorker.Size = new System.Drawing.Size(125, 48);
            this.ButtonBackWorker.TabIndex = 11;
            this.ButtonBackWorker.Text = "Назад";
            this.ButtonBackWorker.UseVisualStyleBackColor = false;
            this.ButtonBackWorker.Click += new System.EventHandler(this.ButtonBackWorker_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(287, 412);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(136, 20);
            this.SearchTextBox.TabIndex = 13;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(242, 415);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(39, 13);
            this.LabelSearch.TabIndex = 14;
            this.LabelSearch.Text = "Посик";
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.BackColor = System.Drawing.Color.Linen;
            this.ButtonRefresh.Location = new System.Drawing.Point(12, 390);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(88, 48);
            this.ButtonRefresh.TabIndex = 12;
            this.ButtonRefresh.Text = "Обновить";
            this.ButtonRefresh.UseVisualStyleBackColor = false;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // LabelInfo
            // 
            this.LabelInfo.AutoSize = true;
            this.LabelInfo.Location = new System.Drawing.Point(106, 390);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(328, 13);
            this.LabelInfo.TabIndex = 15;
            this.LabelInfo.Text = "Для удаления записи нажмите на нужную ячейку и нажмин ОК";
            // 
            // FormTableOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(584, 449);
            this.Controls.Add(this.LabelInfo);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.ButtonBackWorker);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.ButtonBackAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTableOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС Ремонтная мастерская техники ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTableOrders_FormClosed);
            this.Load += new System.EventHandler(this.FormTableOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGrid;
        public System.Windows.Forms.Button ButtonBackAdmin;
        public System.Windows.Forms.Button ButtonBackWorker;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label LabelSearch;
        public System.Windows.Forms.Button ButtonRefresh;
        public System.Windows.Forms.Label LabelInfo;
    }
}