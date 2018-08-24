using System;
using System.Windows.Forms;
using SistemaVotacao.Controller;

namespace SistemaVotacao
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            UserController uControl = new UserController();
            try
            {
                if (uControl.CreateNewUser(tbName.Text, tbLogin.Text, tbPass.Text))
                    this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };

        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }
    }
}
