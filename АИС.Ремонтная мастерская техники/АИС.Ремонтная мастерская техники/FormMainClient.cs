using System;
using System.Windows.Forms;

namespace АИС.Ремонтная_мастерская_техники
{
    public partial class FormMainClient : Form
    {
        public FormMainClient()
        {
            InitializeComponent();
        }
        #region FormAction
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            FormAuthorization frm = new FormAuthorization();
            frm.Show();
            this.Hide();
        }
        private void ButtonOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("У вас уже есть Заказ ?", "Помощь", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                FormPayment frm = new FormPayment();
                frm.Show();
                this.Hide();
            }
            else
            {
                FormOrder frm = new FormOrder();
                frm.Show();
                this.Hide();
            }
        }
        private void ButtonQuestion_Click(object sender, EventArgs e)
        {
            FormQuestion frm = new FormQuestion();
            frm.Show();
            this.Hide();
        }
        private void ButtonBankdetals_Click(object sender, EventArgs e)
        {
            FormBankDetals frm = new FormBankDetals();
            frm.Show();
            this.Hide();
        }
        private void FormMainClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void FormMainClient_Load(object sender, EventArgs e)
        {
            LabelName.Text = $"Добро Пожаловать {DataCase.Name}";
        }
        #endregion
    }
}