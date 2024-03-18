using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace АИС.Ремонтная_мастерская_техники
{
    public partial class FormAuthorizationWorker : Form
    {
        private SQLiteConnection DB;
        public FormAuthorizationWorker()
        {
            InitializeComponent();
        }
        #region FormAction
        private async void FormAuthorizationWorker_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.ConnectionString);
            await DB.OpenAsync();
            TextBoxPassWord.UseSystemPasswordChar = true;
        }
        private void ButtonBack_Click_1(object sender, EventArgs e)
        {
            FormStart frm = new FormStart();
            frm.Show();
            this.Hide();
        }
        private void FormAuthorizationWorker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowPassword.Checked)
            {
                TextBoxPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                TextBoxPassWord.UseSystemPasswordChar = true;
            }
        }
        private async void ButtonNext_Click(object sender, EventArgs e)
        {
            string pass = TextBoxPassWord.Text;
            string Login = TextBoxlogin.Text;

            if (pass != "" && Login != "")
            {
                //Вход на разыне формы по специальности
                SQLiteDataReader sqlReader;
                SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_Employees.main}]" +
                $" WHERE {Table_Employees.Login}=@Login " +
                $" AND {Table_Employees.PassWord}=@PassWord", DB);
                command.Parameters.AddWithValue("Login", Login);
                command.Parameters.AddWithValue("PassWord", pass);
                try 
                {
                    sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                    if (await sqlReader.ReadAsync())
                    {
                        if (sqlReader[$"{Table_Employees.Specialization}"].ToString() == "Генеральный директор")
                        {
                            FormMenuAdmin frm = new FormMenuAdmin();
                            frm.Show();
                            this.Hide();
                            MessageBox.Show("Добро Пожаловать Ген. Директор", "Приятонй работы", MessageBoxButtons.OK);
                        }
                        if (sqlReader[$"{Table_Employees.Specialization}"].ToString() == "Мастер по ремонтным работам")
                        {
                            FormTableOrders frm = new FormTableOrders();
                            frm.Show();
                            frm.ButtonBackAdmin.Visible = false;
                            frm.ButtonRefresh.Visible = false;
                            frm.LabelInfo.Visible = false;
                            this.Hide();
                            MessageBox.Show("Добро Пожаловать Мастер слесарь", "Приятоной работы", MessageBoxButtons.OK);

                        }
                        if (sqlReader[$"{Table_Employees.Specialization}"].ToString() == "Зам.Генерального директора")
                        {
                            FormRegistrationWorker frm = new FormRegistrationWorker();
                            frm.Show();
                            this.Hide();
                            MessageBox.Show("Добро Пожаловать Зам Директора", "Приятоной работы", MessageBoxButtons.OK);
                        }
                        if (sqlReader[$"{Table_Employees.Specialization}"].ToString() == "Кассир")
                        {
                            FormTableOrders frm = new FormTableOrders();
                            frm.Show();
                            frm.ButtonBackAdmin.Visible = false;
                            this.Hide();
                            MessageBox.Show("Добро Пожаловать Кассир", "Приятоной работы", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введен неверный логин или пароль или вы нессотоветсвюте вашей должности", "Ошибка", MessageBoxButtons.OK);
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
    }
}