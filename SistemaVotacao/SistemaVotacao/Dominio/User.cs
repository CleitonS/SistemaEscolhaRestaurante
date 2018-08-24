using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVotacao.Dominio
{
    public class User
    {
        public string name;
        private string login;
        private string pass;
    
        public User(string name, string login, string pass)
        {
            this.name = name;
            this.login = login;
            this.pass = pass;
        }

     
        public string getLogin() { return this.login; }
        public string getPass() { return this.pass; }
    }
}
