using SistemaVotacao.Controller;
using SistemaVotacao.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVotacao.View
{
    public partial class MySession : Form
    {
        User user = null;
        public MySession(User user)
        {
            this.user = user;
            InitializeComponent();
            lWelcome.Text = "Bem vindo, " + user.name;
            this.UpdateRestaurantOfDay(DateTime.Today);

        }

        private void UpdateRestaurantOfDay(DateTime date)
        {
            lDay.Text = date.DayOfWeek.ToString();
            VoteController cVote = new VoteController();
            lRestaurant.Text = cVote.RestaurantOfDay(date);
            lVotes.Text = cVote.VotesOfRestaurantOnDay(date, lRestaurant.Text).ToString();
            listRestaurant.Items.Clear();
            foreach(string rest in cVote.GetAllRestaurant())
                listRestaurant.Items.Add(rest);
        }

        private void MySession_Load(object sender, EventArgs e)
        {

        }

        private void lWelcome_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            this.UpdateRestaurantOfDay(calendar.SelectionRange.Start.Date);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VoteController cVote = new VoteController();
            MessageBox.Show(cVote.Vote(calendar.SelectionRange.Start.Date, this.user.getLogin() ,tbVote.Text));
            this.UpdateRestaurantOfDay(calendar.SelectionRange.Start.Date);

        }

        private void listRestaurant_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbVote.Text = listRestaurant.SelectedItem.ToString();
        }

        private void MySession_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form fmrLogin = new Login();
            fmrLogin.Show();
        }
    }
}
