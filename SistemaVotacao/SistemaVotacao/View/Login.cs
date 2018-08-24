using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVotacao;
using SistemaVotacao.Controller;
using SistemaVotacao.Dominio;
using SistemaVotacao.View;

namespace SistemaVotacao
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            UserController uControl = new UserController();
            User user = null;
            try
            {
                user = uControl.ExecuteLogin(tbLogin.Text, tbPass.Text);
            }catch(Exception ex) { MessageBox.Show(ex.Message); };

            if(user != null)
            {
                Form fmMySession = new MySession(user);
                Visible = false;
                fmMySession.Show();
            }
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            Form fmrCreateUser = new CreateUser();
            fmrCreateUser.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
