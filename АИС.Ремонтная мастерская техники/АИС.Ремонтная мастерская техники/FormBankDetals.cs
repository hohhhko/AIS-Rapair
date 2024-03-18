using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace АИС.Ремонтная_мастерская_техники
{
    public partial class FormBankDetals : Form
    {
        private SQLiteConnection DB;
        public FormBankDetals()
        {
            InitializeComponent();
        }           
        private async void ButtonInsertCard_Click(object sender, EventArgs e)
        {
            string CardCode = TextBoxCardCode.Text;
            string CVC = TextBoxCVC.Text;
            string Name = TextBoxName.Text;
            string Date = TextBoxDate.Text;

            if (CardCode != "" && CVC != "" && Name != "" && Date != "")
            {
                // Команда Добавить
                SQLiteCommand commandInsert = new SQLiteCommand($"INSERT INTO  [{Table_BankDetails.main}] (CardCode, ValidityPeriod, CVC, NameANDSurname, Ballance) " +
                $"VALUES (@CardCode, @ValidityPeriod, @CVC, @NameANDSurname, @Ballance)", DB);
                commandInsert.Parameters.AddWithValue("CardCode", TextBoxCardCode.Text);
                commandInsert.Parameters.AddWithValue("ValidityPeriod", TextBoxDate.Text);
                commandInsert.Parameters.AddWithValue("CVC", TextBoxCVC.Text);
                commandInsert.Parameters.AddWithValue("NameANDSurname", TextBoxName.Text);
                commandInsert.Parameters.AddWithValue("Ballance", 0);
                try
                {
                    await commandInsert.ExecuteNonQueryAsync();
                    MessageBox.Show($"Карта была добавлена \nКод карты: {TextBoxCardCode.Text} Имя: {TextBoxName.Text}", "Картa успешно дабавлена ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TextBoxCardCode.Text = "";
                    TextBoxCVC.Text = "";
                    TextBoxDate.Text = "";
                    TextBoxName.Text = "";
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
            else
            {
                MessageBox.Show("Должны быть заполнены все поля кроме балланса", "Должны быть заполнены поля", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string CardCode = TextBoxCardCode.Text;
            string CVC = TextBoxCVC.Text;
            string Name = TextBoxName.Text;
            string Date = TextBoxDate.Text;
            string Ballance = TextBoxBallance.Text;

            if (CardCode != "" && CVC != "" && Name != "" && Date != "" && Ballance != "")
            {
                // Команда Обновить
                SQLiteCommand commandInsert = new SQLiteCommand($"UPDATE BankDetails SET Ballance = '{TextBoxBallance.Text}'" +
                $" WHERE CardCode = {CardCode}", DB);
                try
                {
                    await commandInsert.ExecuteNonQueryAsync();
                    MessageBox.Show($"Баланс поплнен на сумму \n{TextBoxBallance.Text}", "Баланс пополнен", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TextBoxCardCode.Text = "";
                    TextBoxCVC.Text = "";
                    TextBoxDate.Text = "";
                    TextBoxName.Text = "";
                    TextBoxBallance.Text = "";
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
            else
            {
                MessageBox.Show("Ведите сумму", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void ButtonChek_Click(object sender, EventArgs e)
        {
            string CardCode = TextBoxCardCode.Text;
            string CVC = TextBoxCVC.Text;
            string Name = TextBoxName.Text;
            string Date = TextBoxDate.Text;

            if (CardCode != "" && CVC != "" && Name != "" && Date != "")
            {
                // Команда Считывания данных
                SQLiteDataReader sqlReader;
                SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Table_BankDetails.main}] " +
                $"WHERE {Table_BankDetails.CVC}=@CVC " +
                $"AND {Table_BankDetails.ValidityPeriod}=@ValidityPeriod " +
                $"AND {Table_BankDetails.NameANDSurname}=@NameANDSurname " +
                $"AND {Table_BankDetails.CardCode}=@CardCode", DB);
                command.Parameters.AddWithValue("CardCode", TextBoxCardCode.Text);
                command.Parameters.AddWithValue("CVC", TextBoxCVC.Text);
                command.Parameters.AddWithValue("NameANDSurname", TextBoxName.Text);
                command.Parameters.AddWithValue("ValidityPeriod", TextBoxDate.Text);
                try
                {
                    sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();               
                    if (await sqlReader.ReadAsync())
                    {
                        MessageBox.Show($"Баланс: " + sqlReader["Ballance"], "Проверка Басланса", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Введены не корктные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private async void FormBankDetals_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.ConnectionString);
            await DB.OpenAsync();
        }
        private void FormBankDetals_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            FormMainClient frm = new FormMainClient();
            frm.Show();
            this.Hide();
        }
        #endregion
    }
}