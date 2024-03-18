using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace АИС.Ремонтная_мастерская_техники
{
    public partial class FormQuestion : Form
    {
        private SQLiteConnection DB;

        public  FormQuestion()
        {
            InitializeComponent();
        }
        private async void ButtonQuestion_Click(object sender, EventArgs e)
        {
            SQLiteCommand commandInsert = new SQLiteCommand($"INSERT INTO  [{Table_Questions.main}] (ClientName,Question,ClientPhone,QuestionDate) " +
            $"VALUES (@ClientName, @Question, @ClientPhone, @QuestionDate)", DB);
            commandInsert.Parameters.AddWithValue("ClientName", TextBoxName.Text);
            commandInsert.Parameters.AddWithValue("Question", TextBoxQuestion.Text);
            commandInsert.Parameters.AddWithValue("ClientPhone", TextBoxNumber.Text);
            commandInsert.Parameters.AddWithValue("QuestionDate", Date.Value);
            try
            {
                await commandInsert.ExecuteNonQueryAsync();

                MessageBox.Show("Спасибо за ваш вопрос ожидайте ответа в течении 2 недель", "Вопрос задан", MessageBoxButtons.OK);
                TextBoxName.Text = "";
                TextBoxQuestion.Text = "";
                TextBoxNumber.Text = "";
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
        #region FormAction
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            FormMainClient frm = new FormMainClient();
            frm.Show();
            this.Hide();
        }
        private async void FormQuestion_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.ConnectionString);
            await DB.OpenAsync();
        }
        private void FormQuestion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}