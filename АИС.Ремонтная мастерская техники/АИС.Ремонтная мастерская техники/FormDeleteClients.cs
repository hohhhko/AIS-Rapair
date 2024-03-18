using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace АИС.Ремонтная_мастерская_техники
{
    public partial class FormDeleteClients : Form
    {
        private SQLiteConnection DB;
        public FormDeleteClients()
        {
            InitializeComponent();
        }
        private async void ButtonDelete_Click(object sender, EventArgs e)
        {
            string login = TextBoxlogin.Text;
            string pass = TextBoxPassWord.Text;

            if (login != "" && pass != "")
            {
                // Команда удаления
                SQLiteCommand commandDelеte = new SQLiteCommand($"DELETE FROM Clients " +
                $"WHERE Login = '{login}'", DB);
                await commandDelеte.ExecuteNonQueryAsync();
                MessageBox.Show("Пользователь удален", "Удалено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TextBoxlogin.Text = "";
                TextBoxPassWord.Text = "";
            }
            else
            {
                MessageBox.Show("Пользователь ненайден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region FormAction
        private async void FormDeleteClients_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.ConnectionString);
            await DB.OpenAsync();
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            FormAuthorization frm = new FormAuthorization();
            frm.Show();
            this.Hide();
        }
        private void FormDeleteClients_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}