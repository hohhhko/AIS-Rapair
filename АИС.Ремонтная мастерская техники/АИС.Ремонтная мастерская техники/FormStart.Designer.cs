
namespace АИС.Ремонтная_мастерская_техники
{
    partial class FormStart
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.ButtonClient = new System.Windows.Forms.Button();
            this.ButtonWorker = new System.Windows.Forms.Button();
            this.LabelHello = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ДокументацияToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.РуководтсвоПользователяToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ПрезентацияПроектаToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.НастрокиToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonClient
            // 
            this.ButtonClient.BackColor = System.Drawing.Color.Khaki;
            this.ButtonClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClient.Location = new System.Drawing.Point(232, 131);
            this.ButtonClient.Name = "ButtonClient";
            this.ButtonClient.Size = new System.Drawing.Size(145, 66);
            this.ButtonClient.TabIndex = 0;
            this.ButtonClient.Text = "Клиент";
            this.ButtonClient.UseVisualStyleBackColor = false;
            this.ButtonClient.Click += new System.EventHandler(this.ButtonClient_Click);
            // 
            // ButtonWorker
            // 
            this.ButtonWorker.BackColor = System.Drawing.Color.PeachPuff;
            this.ButtonWorker.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonWorker.Location = new System.Drawing.Point(232, 239);
            this.ButtonWorker.Name = "ButtonWorker";
            this.ButtonWorker.Size = new System.Drawing.Size(145, 66);
            this.ButtonWorker.TabIndex = 1;
            this.ButtonWorker.Text = "Рабочий ";
            this.ButtonWorker.UseVisualStyleBackColor = false;
            this.ButtonWorker.Click += new System.EventHandler(this.ButtonWorker_Click);
            // 
            // LabelHello
            // 
            this.LabelHello.AutoSize = true;
            this.LabelHello.BackColor = System.Drawing.Color.NavajoWhite;
            this.LabelHello.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHello.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelHello.Location = new System.Drawing.Point(69, 30);
            this.LabelHello.Name = "LabelHello";
            this.LabelHello.Size = new System.Drawing.Size(478, 46);
            this.LabelHello.TabIndex = 2;
            this.LabelHello.Text = "Приветствую пользователь добро пожаловать \r\n в Ремонтную мастерскую техники\r\n";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ДокументацияToolStripMenu,
            this.НастрокиToolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ДокументацияToolStripMenu
            // 
            this.ДокументацияToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.РуководтсвоПользователяToolStripMenu,
            this.ПрезентацияПроектаToolStripMenu});
            this.ДокументацияToolStripMenu.Name = "ДокументацияToolStripMenu";
            this.ДокументацияToolStripMenu.Size = new System.Drawing.Size(102, 20);
            this.ДокументацияToolStripMenu.Text = "Документация ";
            // 
            // РуководтсвоПользователяToolStripMenu
            // 
            this.РуководтсвоПользователяToolStripMenu.Name = "РуководтсвоПользователяToolStripMenu";
            this.РуководтсвоПользователяToolStripMenu.Size = new System.Drawing.Size(221, 22);
            this.РуководтсвоПользователяToolStripMenu.Text = "Руководтсво пользователя";
            this.РуководтсвоПользователяToolStripMenu.Click += new System.EventHandler(this.РуководтсвоПользователяToolStripMenu_Click_1);
            // 
            // ПрезентацияПроектаToolStripMenu
            // 
            this.ПрезентацияПроектаToolStripMenu.Name = "ПрезентацияПроектаToolStripMenu";
            this.ПрезентацияПроектаToolStripMenu.Size = new System.Drawing.Size(221, 22);
            this.ПрезентацияПроектаToolStripMenu.Text = "Презентация проекта";
            this.ПрезентацияПроектаToolStripMenu.Click += new System.EventHandler(this.ПрезентацияПроектаToolStripMenu_Click);
            // 
            // НастрокиToolStripMenu
            // 
            this.НастрокиToolStripMenu.Name = "НастрокиToolStripMenu";
            this.НастрокиToolStripMenu.Size = new System.Drawing.Size(79, 20);
            this.НастрокиToolStripMenu.Text = "Настройки";
            this.НастрокиToolStripMenu.Click += new System.EventHandler(this.НастрокиToolStripMenuItem_Click_1);
            // 
            // Picture
            // 
            this.Picture.Image = global::АИС.Ремонтная_мастерская_техники.Properties.Resources.maxresdefault;
            this.Picture.Location = new System.Drawing.Point(1, 27);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(675, 361);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 3;
            this.Picture.TabStop = false;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 386);
            this.Controls.Add(this.LabelHello);
            this.Controls.Add(this.ButtonWorker);
            this.Controls.Add(this.ButtonClient);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС Ремонтная мастерская техники ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStart_FormClosed);
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonClient;
        private System.Windows.Forms.Button ButtonWorker;
        private System.Windows.Forms.Label LabelHello;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ДокументацияToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem РуководтсвоПользователяToolStripMenu;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.ToolStripMenuItem ПрезентацияПроектаToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem НастрокиToolStripMenu;
    }
}

