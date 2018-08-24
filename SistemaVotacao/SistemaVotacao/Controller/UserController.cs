using SistemaVotacao.Dominio;
using SistemaVotacao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVotacao.Controller
{
    class UserController
    {
        public UserController() { }
        
        public bool CreateNewUser(string name, string login, string pass)
        {
            UserModel userModel = new UserModel();
            try
            {
                userModel.CreateUser(name, login, pass);
            }
            catch (Exception e)
            {
                Console.Write("Error: " + e.Message);
                throw e;
            };
            return true;
        }

        public User ExecuteLogin(string login, string pass)
        {
            UserModel userModel = new UserModel();
            User user;
            try
            {
                user = userModel.ExecuteLogin(login, pass);

            }catch(Exception e)
            {
                Console.Write("Error: " + e.Message);
                throw e;                
            }

            return user;
        }
    }
}
