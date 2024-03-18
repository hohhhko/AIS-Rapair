using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace АИС.Ремонтная_мастерская_техники
{
    public partial class FormRegistrationWorker : Form
    {
        private SQLiteConnection DB;
        public FormRegistrationWorker()
        {
            InitializeComponent();
        }
        private async void ButtonRegistation_Click(object sender, EventArgs e)
        {
            string Pass = TextBoxPass.Text;
            string Login = TextBoxLogin.Text;
            string Salary = TextBoxSallary.Text;
            string Specalization = ComboBoxSpecalization.Text;
            string Documents = TextBoxDocuments.Text;
            string Phone = TextBoxPhone.Text;
            string Name = TextBoxName.Text;

            if (Pass != "" && Login != "" && Specalization != "" && Name != "")
            {
                SQLiteCommand commandinsert = new SQLiteCommand($"INSERT INTO [{Table_Employees.main}] (Login, PassWord, EmployeeName, PhoneNumber, Dokuments, AdmissionDate, Salary, Specialization) " +
                $"VALUES (@Login, @PassWord, @EmployeeName, @PhoneNumber, @Dokuments, @AdmissionDate, @Salary, @Specialization)", DB);
                commandinsert.Parameters.AddWithValue("Login", Login);
                commandinsert.Parameters.AddWithValue("PassWord", Pass);
                commandinsert.Parameters.AddWithValue("Salary", Salary);
                commandinsert.Parameters.AddWithValue("Specialization", Specalization);
                commandinsert.Parameters.AddWithValue("Dokuments", Documents);
                commandinsert.Parameters.AddWithValue("PhoneNumber", Phone);
                commandinsert.Parameters.AddWithValue("EmployeeName", Name);
                commandinsert.Parameters.AddWithValue("AdmissionDate", DateTime.Value);
                try
                {
                    await commandinsert.ExecuteNonQueryAsync();

                    MessageBox.Show("Работник добавлен", "Успех", MessageBoxButtons.OK);
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
            FormAuthorizationWorker frm = new FormAuthorizationWorker();
            frm.Show();
            this.Hide();
        }
        private async void FormRegistrationWorker_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.ConnectionString);
            await DB.OpenAsync();
        }
        private void FormRegistrationWorker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}