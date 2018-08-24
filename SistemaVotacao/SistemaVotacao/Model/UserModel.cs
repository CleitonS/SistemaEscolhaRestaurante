using SistemaVotacao.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVotacao.Model
{
    class UserModel
    {
        public User CreateUser(string name, string login, string pass)
        {
            ISingleton instSingle = SingletonTXT.getInstance();
            if (name != "" && login != "" && pass != "")
            {
                if (instSingle.FindLogin(login) != null)
                    throw new Exception("Login já existente");                
                else
                {
                    User newUser = new User(name, login, pass);
                    instSingle.CreateUser(newUser);
                    return newUser;
                }
            }
            throw new Exception("Entrada Inválida");
        }

        public User ExecuteLogin(string login, string pass)
        {
            ISingleton instSingle = SingletonTXT.getInstance();
            User user = instSingle.FindLogin(login);

            //Console.Write(user.getPass().Equals(pass).ToString());

            if (user == null)
                Console.WriteLine("É NULOOO");

            if (user != null && user.getPass().Equals(pass))
                return user;
            else
                throw new Exception("´Login ou Senha inválidos");
        }
    }
}
