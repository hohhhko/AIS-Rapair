using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace АИС.Ремонтная_мастерская_техники
{
    public partial class FormOrder : Form
    {
        private SQLiteConnection DB;
        public FormOrder()
        {
            InitializeComponent();
        }
        private void UpdateSelectedElementInfo()
        {
            //Выводит значения в textBoxSummOfOrders.
            TextBoxSummOfOrders.Text = "Выбирите услугу";

            if (ListBoxOrders.SelectedIndex == 0)
            {   
                TextBoxSummOfOrders.Text =  "10000";
            }
            if (ListBoxOrders.SelectedIndex == 1)
            {
                TextBoxSummOfOrders.Text =  "600";
            }
            if (ListBoxOrders.SelectedIndex == 2)
            {
                TextBoxSummOfOrders.Text = "0";
            }
            if (ListBoxOrders.SelectedIndex == 3)
            {
                TextBoxSummOfOrders.Text =  "500";
            }
        }
        private async void ButtonCancelOrder_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            string stuf = TextBoxStuf.Text; 

            if (name != "" && stuf !="")
            {
                SQLiteCommand commandDelate = new SQLiteCommand($"DELETE FROM Orders" +
                $" WHERE ClientName  = '{TextBoxName.Text}'", DB);
                try
                {
                    await commandDelate.ExecuteNonQueryAsync();
                    MessageBox.Show("Заказ Удален", "Удалено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TextBoxName.Text = "";
                    TextBoxStuf.Text = "";
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
                MessageBox.Show("Заказ не найден","Ошибка",MessageBoxButtons.OK);
            }
        }
        private void ListBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedElementInfo();
        }
        private async void ButtonNext_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            string stuf = TextBoxStuf.Text;
            string servers = ListBoxOrders.Text;

            if (name != "" && stuf != "" && servers != "")
            {
                SQLiteCommand commandInsert = new SQLiteCommand($" INSERT INTO [{Table_Orders.main}] (ClientName, OrderItem, OrderDate, Servise, TheCostOfTheOrder) " +
                $"VALUES (@ClientName, @OrderItem, @OrderDate, @Servise, @TheCostOfTheOrder)", DB);
                commandInsert.Parameters.AddWithValue("Servise", ListBoxOrders.Text);
                commandInsert.Parameters.AddWithValue("OrderItem", TextBoxStuf.Text);
                commandInsert.Parameters.AddWithValue("TheCostOfTheOrder", TextBoxSummOfOrders.Text);
                commandInsert.Parameters.AddWithValue("ClientName", TextBoxName.Text);
                commandInsert.Parameters.AddWithValue("OrderDate", DateTime.Value);
                try
                {
                    await commandInsert.ExecuteNonQueryAsync();

                    MessageBox.Show("Заказ добавлен осталось оплатить", "Заказ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormPayment frm = new FormPayment();
                    frm.Show();
                    this.Hide();
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
                MessageBox.Show("Заказ не обаботан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region FormAction
        private void FormOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private async void FormOrder_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.ConnectionString);
            await DB.OpenAsync();

            UpdateSelectedElementInfo();
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