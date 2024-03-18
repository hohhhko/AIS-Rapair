using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace АИС.Ремонтная_мастерская_техники
{
    public partial class FormTableTreashcan : Form
    {
        private SQLiteConnection DB;
        public FormTableTreashcan()
        {
            InitializeComponent();
        }
        #region FormAction
        private void FormTableTreashcan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private async void FormTableTreashcan_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.ConnectionString);
            await DB.OpenAsync();

            // Вывод данных на таблицу.
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM Trashcan", DB);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "Info");
            DataGrid.DataSource = ds.Tables[0];
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            FormMenuAdmin frm = new FormMenuAdmin();
            frm.Show();
            this.Hide();
        }
        #endregion
    }
}