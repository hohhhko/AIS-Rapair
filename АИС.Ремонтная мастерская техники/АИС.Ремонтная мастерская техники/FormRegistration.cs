using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace АИС.Ремонтная_мастерская_техники
{
    public partial class FormRegistration : Form
    {
        private SQLiteConnection DB;
        public FormRegistration()
        {
            InitializeComponent();
        }
        private async void ButtonRegistrtion_Click(object sender, EventArgs e)
        {
            string login = TextBoxLogin.Text;
            string pass = TextBoxPass.Text;
            string name = TextBoxName.Text;

            if (login != "" && pass != "" && name != "")
            {
                SQLiteDataReader sqlReader;
                SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_Clients.main}] " +
                $"WHERE {Table_Clients.Login}=@Login " +
                $"AND {Table_Clients.PassWord}=@PassWord " +
                $"AND {Table_Clients.ClientName}=@ClientName", DB);
                command.Parameters.AddWithValue("Login", TextBoxLogin.Text);
                command.Parameters.AddWithValue("PassWord", TextBoxPass.Text);
                command.Parameters.AddWithValue("ClientName", TextBoxName.Text);
                try
                {
                    sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                    if (await sqlReader.ReadAsync())
                    {
                        MessageBox.Show("Такой пользователь уже есть ", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        SQLiteCommand commandInsert = new SQLiteCommand($"INSERT INTO  [{Table_Clients.main}] (ClientName, Login, Password, DateofRegistration) " +
                        $"VALUES (@ClientName, @Login, @Password, @DateofRegistration)", DB);
                        commandInsert.Parameters.AddWithValue("Login", TextBoxLogin.Text);
                        commandInsert.Parameters.AddWithValue("ClientName", TextBoxName.Text);
                        commandInsert.Parameters.AddWithValue("Password", TextBoxPass.Text);
                        commandInsert.Parameters.AddWithValue("DateofRegistration", Datetime.Value);
                        await commandInsert.ExecuteNonQueryAsync();
                        MessageBox.Show($"Пользователь успешно зарегистрирован!\nЛогин: {TextBoxLogin.Text} Пароль: {TextBoxPass.Text}", "Регистрация нового пользователя прошла успешно ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TextBoxLogin.Text = "";
                        TextBoxName.Text = "";
                        TextBoxPass.Text = "";
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
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            FormAuthorization frm = new FormAuthorization();
            frm.Show();
            this.Hide();
        }
        private async void FormRegistration_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.ConnectionString);
            await DB.OpenAsync();
        }
        private void FormRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}