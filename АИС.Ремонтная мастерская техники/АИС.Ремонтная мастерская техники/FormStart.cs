using System;
using System.Net;
using System.Windows.Forms;

namespace АИС.Ремонтная_мастерская_техники
{
    public partial class FormStart : Form
    {
        WebClient Client = new WebClient();
        public FormStart()
        {
            InitializeComponent();
        }
        #region FormAction
        private void НастрокиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormSetings frm = new FormSetings();
            frm.Show();
            this.Hide();
        }
        // Процесс обновления приложения
        private void FormStart_Load(object sender, EventArgs e)
        {
            if (Client.DownloadString("").Contains(""))
            {
                MessageBox.Show("У вас актальная версия");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Вышла новая версия пожалуста обновите","Обновление",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
                if (dr == DialogResult.OK)
                {
                    Client.DownloadFile("", "");
                }
                else
                {
                    MessageBox.Show("Лучше обновите там новые возможности");
                }
            }

        }
        private void FormStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ButtonWorker_Click(object sender, EventArgs e)
        {
            FormAuthorizationWorker frm = new FormAuthorizationWorker();
            frm.Show();
            this.Hide();
        }
        private void ButtonClient_Click(object sender, EventArgs e)
        {
            FormAuthorization frm = new FormAuthorization();
            frm.Show();
            this.Hide();
        }
        #endregion
        private void ПрезентацияПроектаToolStripMenu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("АИС Ремонтная мастерская техники Презентация продукта.pptx");
        }
        private void РуководтсвоПользователяToolStripMenu_Click_1(object sender, EventArgs e)
        {
            // Открытие указоного файла (файл находится рядом с самим приложением, иначе нужно указывать полный путь до него).
            System.Diagnostics.Process.Start("АИС Ремонтная мастерская техники  Руковдтсво пользователя.docx");
        }
    }
}