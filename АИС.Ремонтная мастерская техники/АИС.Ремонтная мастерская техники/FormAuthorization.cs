using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace АИС.Ремонтная_мастерская_техники
{
    public partial class FormAuthorization : Form
    {
        //Упрошение класса для подключения к бд.
        private SQLiteConnection DB;
        public FormAuthorization()
        {
            InitializeComponent();
            TextBoxPass.UseSystemPasswordChar = true;
        }
        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowPassword.Checked)
            {
                TextBoxPass.UseSystemPasswordChar = false;
            }
            else
            {
                TextBoxPass.UseSystemPasswordChar = true;
            }
        }
        private async void ButtonNext_Click(object sender, EventArgs e)
        {
            string login = TextBoxLogin.Text;
            string pass = TextBoxPass.Text;

            if (login != "" && pass != "")
            {
                SQLiteDataReader sqlReader;
                SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_Clients.main}] " +
                $"WHERE {Table_Clients.Login}=@Login " +
                $"AND {Table_Clients.PassWord}=@PassWord ", DB);
                command.Parameters.AddWithValue("Login", TextBoxLogin.Text);
                command.Parameters.AddWithValue("PassWord", TextBoxPass.Text);
                try
                {
                    sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                    if (await sqlReader.ReadAsync())
                    {
                        DataCase.Name = sqlReader[$"{Table_Clients.ClientName}"].ToString();
                        DataCase.Login = sqlReader[$"{Table_Clients.Login}"].ToString();
                        FormMainClient frm = new FormMainClient();
                        frm.Show();
                        this.Hide();
                        MessageBox.Show("Вход прошол успешно", "Успех", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Вход не выполнен введены некоректные данные", "Ошибка входа ", MessageBoxButtons.OK);
                        return;
                    }
                    sqlReader.Close();
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
        #region FormAction
        private void FormAuthorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            FormStart frm = new FormStart();
            frm.Show();
            this.Hide();
        }
        private async void FormAuthorization_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.ConnectionString);
            await DB.OpenAsync();
        }
        private void ButtonDeleteClient_Click(object sender, EventArgs e)
        {
            FormDeleteClients frm = new FormDeleteClients();
            frm.Show();
            this.Hide();
        }
        private void ButtonRegistationClient_Click(object sender, EventArgs e)
        {
            FormRegistration frm = new FormRegistration();
            frm.Show();
            this.Hide();
        }
        #endregion
    }
}