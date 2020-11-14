using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Insert_in_Database__MDI_
{
    public partial class Form1 : Form
    {
        PassengerForm PassangerForm;
        PiloteForm PiloteForm;
        public Form1()
        {
            InitializeComponent();

        }

        private void PassagerItem_Click(object sender, EventArgs e)
        {
            PassangerForm = new PassengerForm();
            Changer_Form(PassangerForm);
        }

        private void PiloteItem_Click(object sender, EventArgs e)
        {
            PiloteForm = new PiloteForm();
            Changer_Form(PiloteForm);
        }

        void Changer_Form(Form NewForm)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            NewForm.MdiParent = this;
            NewForm.Dock = DockStyle.Fill;
            NewForm.Show();
        }
    }
}
