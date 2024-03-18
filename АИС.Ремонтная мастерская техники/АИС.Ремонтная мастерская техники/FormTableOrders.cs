using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace АИС.Ремонтная_мастерская_техники
{
    public partial class FormTableOrders : Form
    {
        private SQLiteConnection DB;
        public FormTableOrders()
        {
            InitializeComponent();
        }
        #region FormAction
        private void ButtonBackWorker_Click(object sender, EventArgs e)
        {
            FormAuthorizationWorker frm = new FormAuthorizationWorker();
            frm.Show();
            this.Hide();
        }
        private void ButtonBackAdmin_Click(object sender, EventArgs e)
        {
            FormMenuAdmin frm = new FormMenuAdmin();
            frm.Show();
            this.Hide();
        }
        private void FormTableOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            ButtonBackAdmin.Visible = true;
            ButtonRefresh.Visible = true;
            LabelInfo.Visible = true;
        }
        private async void FormTableOrders_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.ConnectionString);
            await DB.OpenAsync();

            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM Orders", DB);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "Info");
            DataGrid.DataSource = ds.Tables[0];
        }
        #endregion
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            // Обнавляет таблицу на форме
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM Orders", DB);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "Info");
            DataGrid.DataSource = ds.Tables[0];
        }
        private void SearchTextBox_TextChanged(object sender, EventArgs e) 
        {
            DataGrid.ClearSelection();

            // Поиск в таблице по буквам
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
                return;

            var values = SearchTextBox.Text.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < DataGrid.RowCount - 1; i++)
            {
                foreach (string value in values)
                {
                    var row = DataGrid.Rows[i];

                    if (row.Cells["id"].Value.ToString().Contains(value) ||
                        row.Cells["ClientName"].Value.ToString().Contains(value))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
        }
        private async void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                // Нахождение нажатой ячейки в таблице.
                int id_table = Convert.ToInt32(DataGrid.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());

                //Удаление записи по нажатию по ячейке.
                SQLiteCommand commandDelate = new SQLiteCommand($"DELETE FROM {Table_Orders.main} " +
                $"WHERE id = '" + id_table + "' ", DB);
                await commandDelate.ExecuteNonQueryAsync();
                MessageBox.Show("Запись удаелна", "Удалено", MessageBoxButtons.OK);
            }
        }
    }
}