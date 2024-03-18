using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace АИС.Ремонтная_мастерская_техники
{
    public partial class FormPayment : Form
    {
        private SQLiteConnection DB;
        public FormPayment()
        {
            InitializeComponent();
        }
        private async void FormPayment_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.ConnectionString);
            await DB.OpenAsync();
        }
        private void FormPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private async void ButtonPay_Click(object sender, EventArgs e)
        {
            string card = TextBoxCardCode.Text;
            string CVC = TextBoxCVC.Text;
            string date = TextBoxDate.Text;
            string Name = TextBoxName.Text;
            int Balance = 0;
            int Order = 0;

            if (card != "" && CVC != "" && date != "" && Name != "")
            {
                // Берет значения из таблицы Заказов и таблицы Банковских данных и конвертирует их в число.
                SQLiteDataReader sqlReader;
                SQLiteCommand command1 = new SQLiteCommand($" SELECT * FROM [{Table_Orders.main}] " +
                $"WHERE {Table_Orders.ClientName}=@ClientName", DB);
                command1.Parameters.AddWithValue("ClientName", TextBoxName.Text);
                sqlReader = (SQLiteDataReader)await command1.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    Order = int.Parse(sqlReader[$"{Table_Orders.TheCostOfTheOrder}"].ToString());
                }          
                SQLiteCommand command2 = new SQLiteCommand($" SELECT * FROM [{Table_BankDetails.main}] " +
                $"WHERE CardCode=@CardCode", DB);
                command2.Parameters.AddWithValue("CardCode", TextBoxCardCode.Text);
                sqlReader = (SQLiteDataReader)await command2.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    Balance = int.Parse(sqlReader[$"{Table_BankDetails.Ballance}"].ToString());
                }
                // Вычитает эти данные и записывает в таблицу Банковских данных в виде текста.
                SQLiteCommand commandInsert = new SQLiteCommand($"UPDATE BankDetails SET Ballance =@balance " +
                $"WHERE CardCode =@card", DB);
                commandInsert.Parameters.AddWithValue("balance", Balance-Order);
                commandInsert.Parameters.AddWithValue("card", card);
                try
                {
                    await commandInsert.ExecuteNonQueryAsync();
                    MessageBox.Show("Закааз оплачен", "Оплата", MessageBoxButtons.OK);

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
        }
        private void ButtonCancelOrder_Click(object sender, EventArgs e)
        {
            // Возвращяет на предыдущюю форму если выбрали "да".
            DialogResult result = MessageBox.Show(" Oтменить ваш заказ", "Отмена", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                FormOrder frm = new FormOrder();
                frm.Show();
                frm.ButtonCancelOrder.Visible = true;
                this.Hide();
                MessageBox.Show("Заполинте поле вашего имени и ваш предмет вашего заказа", "Помощь", MessageBoxButtons.OK);
            }
        }
    }
}