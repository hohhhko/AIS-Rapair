using System;
using System.Windows.Forms;

namespace АИС.Ремонтная_мастерская_техники
{
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
        }
        #region FormAction
        private void ButtonQuestion_Click(object sender, EventArgs e)
        {
            FormTableQuestions frm = new FormTableQuestions();
            frm.Show();
            this.Hide();
        }
        private void FormMenuAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            FormAuthorizationWorker frm = new FormAuthorizationWorker();
            frm.Show();
            this.Hide();
        }
        private void ButtonTrashCan_Click(object sender, EventArgs e)
        {
            FormTableTreashcan frm = new FormTableTreashcan();
            frm.Show();
            this.Hide();
        }
        private void ButtonOrder_Click(object sender, EventArgs e)
        {
            FormTableOrders frm = new FormTableOrders();
            frm.Show();
            frm.ButtonBackWorker.Visible = false;
            this.Hide();
        }
        #endregion
    }
}