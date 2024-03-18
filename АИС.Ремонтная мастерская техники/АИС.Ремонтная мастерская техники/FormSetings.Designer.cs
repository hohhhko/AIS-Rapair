
namespace АИС.Ремонтная_мастерская_техники
{
    partial class FormSetings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetings));
            this.ButtonBack = new System.Windows.Forms.Button();
            this.RadioButtonStatic = new System.Windows.Forms.RadioButton();
            this.RadioButtonDiname = new System.Windows.Forms.RadioButton();
            this.ButtonNormal = new System.Windows.Forms.Button();
            this.Button800x600 = new System.Windows.Forms.Button();
            this.labelFrame = new System.Windows.Forms.Label();
            this.LabelWindow = new System.Windows.Forms.Label();
            this.LabelMain = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.ButtonCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(474, 262);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(103, 59);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // RadioButtonStatic
            // 
            this.RadioButtonStatic.AutoSize = true;
            this.RadioButtonStatic.Location = new System.Drawing.Point(27, 162);
            this.RadioButtonStatic.Name = "RadioButtonStatic";
            this.RadioButtonStatic.Size = new System.Drawing.Size(136, 17);
            this.RadioButtonStatic.TabIndex = 1;
            this.RadioButtonStatic.TabStop = true;
            this.RadioButtonStatic.Text = "Стаичный без рамаки";
            this.RadioButtonStatic.UseVisualStyleBackColor = true;
            this.RadioButtonStatic.CheckedChanged += new System.EventHandler(this.RadioButtonStatic_CheckedChanged);
            // 
            // RadioButtonDiname
            // 
            this.RadioButtonDiname.AutoSize = true;
            this.RadioButtonDiname.Location = new System.Drawing.Point(27, 121);
            this.RadioButtonDiname.Name = "RadioButtonDiname";
            this.RadioButtonDiname.Size = new System.Drawing.Size(151, 17);
            this.RadioButtonDiname.TabIndex = 2;
            this.RadioButtonDiname.TabStop = true;
            this.RadioButtonDiname.Text = "С рамкой и динамичный ";
            this.RadioButtonDiname.UseVisualStyleBackColor = true;
            this.RadioButtonDiname.CheckedChanged += new System.EventHandler(this.RadioButtonDiname_CheckedChanged);
            // 
            // ButtonNormal
            // 
            this.ButtonNormal.Location = new System.Drawing.Point(451, 81);
            this.ButtonNormal.Name = "ButtonNormal";
            this.ButtonNormal.Size = new System.Drawing.Size(105, 41);
            this.ButtonNormal.TabIndex = 3;
            this.ButtonNormal.Text = "По умолчанию";
            this.ButtonNormal.UseVisualStyleBackColor = true;
            this.ButtonNormal.Click += new System.EventHandler(this.ButtonNormal_Click);
            // 
            // Button800x600
            // 
            this.Button800x600.Location = new System.Drawing.Point(451, 147);
            this.Button800x600.Name = "Button800x600";
            this.Button800x600.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button800x600.Size = new System.Drawing.Size(104, 47);
            this.Button800x600.TabIndex = 4;
            this.Button800x600.Text = "800x600";
            this.Button800x600.UseVisualStyleBackColor = true;
            this.Button800x600.Click += new System.EventHandler(this.Button800x600_Click);
            // 
            // labelFrame
            // 
            this.labelFrame.AutoSize = true;
            this.labelFrame.Location = new System.Drawing.Point(476, 44);
            this.labelFrame.Name = "labelFrame";
            this.labelFrame.Size = new System.Drawing.Size(67, 13);
            this.labelFrame.TabIndex = 5;
            this.labelFrame.Text = "Размер окн";
            // 
            // LabelWindow
            // 
            this.LabelWindow.AutoSize = true;
            this.LabelWindow.Location = new System.Drawing.Point(24, 81);
            this.LabelWindow.Name = "LabelWindow";
            this.LabelWindow.Size = new System.Drawing.Size(63, 13);
            this.LabelWindow.TabIndex = 6;
            this.LabelWindow.Text = "Режим окн";
            // 
            // LabelMain
            // 
            this.LabelMain.AutoSize = true;
            this.LabelMain.Location = new System.Drawing.Point(193, 21);
            this.LabelMain.Name = "LabelMain";
            this.LabelMain.Size = new System.Drawing.Size(88, 13);
            this.LabelMain.TabIndex = 7;
            this.LabelMain.Text = "Меню Настроек";
            // 
            // picture
            // 
            this.picture.Image = global::АИС.Ремонтная_мастерская_техники.Properties.Resources._970413886;
            this.picture.Location = new System.Drawing.Point(2, -3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(607, 334);
            this.picture.TabIndex = 8;
            this.picture.TabStop = false;
            // 
            // ButtonCopy
            // 
            this.ButtonCopy.Location = new System.Drawing.Point(27, 262);
            this.ButtonCopy.Name = "ButtonCopy";
            this.ButtonCopy.Size = new System.Drawing.Size(109, 43);
            this.ButtonCopy.TabIndex = 9;
            this.ButtonCopy.Text = "Копирование БД";
            this.ButtonCopy.UseVisualStyleBackColor = true;
            this.ButtonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // FormSetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 333);
            this.Controls.Add(this.ButtonCopy);
            this.Controls.Add(this.LabelMain);
            this.Controls.Add(this.LabelWindow);
            this.Controls.Add(this.labelFrame);
            this.Controls.Add(this.Button800x600);
            this.Controls.Add(this.ButtonNormal);
            this.Controls.Add(this.RadioButtonDiname);
            this.Controls.Add(this.RadioButtonStatic);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.picture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSetings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС Ремонтная мастерская техники ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSetings_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.RadioButton RadioButtonStatic;
        private System.Windows.Forms.RadioButton RadioButtonDiname;
        private System.Windows.Forms.Button ButtonNormal;
        private System.Windows.Forms.Button Button800x600;
        private System.Windows.Forms.Label labelFrame;
        private System.Windows.Forms.Label LabelWindow;
        private System.Windows.Forms.Label LabelMain;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button ButtonCopy;
    }
}