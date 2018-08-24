using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVotacao.Dominio
{
    class Vote
    {
        public string restaurant;
        public DateTime date;
        public string login;

        public Vote(string restaurant, DateTime date, string login)
        {
            this.restaurant = restaurant;
            this.date = date;
            this.login = login;
        }
    }
}
