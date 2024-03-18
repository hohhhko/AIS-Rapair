using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace АИС.Ремонтная_мастерская_техники
{
    public partial class FormSetings : Form
    {
        public FormSetings()
        {
            InitializeComponent();
        }
        #region FormAction
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            FormStart frm = new FormStart();
            frm.Show();
            this.Hide();
        }
        private void Button800x600_Click(object sender, EventArgs e)
        {
            this.Size = new Size(800, 600); // Установка размера текущего окна.
            picture.Size = new Size(800, 600);
        }
        private void ButtonNormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(625, 372);
            picture.Size = new Size(625, 372);
        }
        private void RadioButtonStatic_CheckedChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None; // Установка режима окна. 
            FormStart formStart = new FormStart();
            FormStart frm = formStart;
            frm.FormBorderStyle = FormBorderStyle.None;
        }
        private void RadioButtonDiname_CheckedChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            FormStart formStart = new FormStart();
            FormStart frm = formStart;
            frm.FormBorderStyle = FormBorderStyle.Fixed3D;
        }
        private void FormSetings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

       // Кнопка отвечающая за копирование БД
        public async void ButtonCopy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выбирите место куда хотите скопировать БД");

            string pickDataBase = Environment.CurrentDirectory;
            var dataBaseName = "database.db";

            using (var bfd = new FolderBrowserDialog())
            {
                try
                {
                    DialogResult result = bfd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrEmpty(bfd.SelectedPath))
                    {
                        var backupTo = bfd.SelectedPath + "\\" + (Path.GetFileNameWithoutExtension(dataBaseName) + ".db");

                        SqliteDataAccess.backup(pickDataBase, dataBaseName, backupTo);

                        MessageBox.Show("Скопировано");
                    }
                }
                catch (Exception read)
                {
                    string path = "Errors Users.txt";
                    string text = read.ToString();
                    string Useer = ($"{DataCase.Name}, Логин: {DataCase.Login}");
                    System.Diagnostics.Process.Start("ConfiguratorPC.exe");

                    using (StreamWriter writer = new StreamWriter(path, false))
                    {
                        await writer.WriteLineAsync();
                        await writer.WriteLineAsync("Ошибка:" + text);
                        await writer.WriteLineAsync();
                        await writer.WriteLineAsync($"{read.Message}");
                        await writer.WriteLineAsync();
                        await writer.WriteLineAsync("Ошибка Пользователя:" + Useer);
                    }
                    DialogResult dr = MessageBox.Show($"Возникла Критическая Ошибка:{read.Message}, " +
                    $"Подробности в текстовом файле Открыть ?", "Ошибка", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        System.Diagnostics.Process.Start("Errors Users.txt");
                    }
                }
            }
        }
    }
    // Класс для копирования БД
    public class SqliteDataAccess
    {
        public static void backup(string filePath, string scrName, string destfile)
        {
            var scrfile = Path.Combine(filePath, scrName);
            var desfile = Path.Combine(filePath, destfile);

            if (File.Exists(desfile)) File.Delete(desfile);
            {
                File.Copy(scrfile, desfile);
            }
        }
    }
}