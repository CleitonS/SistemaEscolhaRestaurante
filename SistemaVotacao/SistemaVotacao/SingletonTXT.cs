using SistemaVotacao.Dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVotacao
{
    class SingletonTXT : ISingleton
    {

        //Estrutura do arquivo User: <nome>;<login>;<senha> 
        private string dbUser; //= "C:\\Users\\Cleiton\\Desktop\\DbServer\\SistemaVotacao\\SistemaVotacao\\User.txt";
        //Estrutura do arquivo Votes: <dd/mm/aaaa>;<login>;<Restaurant> 
        private string dbVote; //= "C:\\Users\\Cleiton\\Desktop\\DbServer\\SistemaVotacao\\SistemaVotacao\\Vote.txt";
        private static SingletonTXT instance = new SingletonTXT();
        private SingletonTXT()
        {

            String[] list = Directory.GetCurrentDirectory().ToString().Split('\\');
            dbUser = list[0] + '\\' + list[1] + '\\' + list[2] + "\\User.txt";
            dbVote = list[0] + '\\' + list[1] + '\\' + list[2] + "\\Vote.txt";
            StreamWriter arqOpen = null;
            if (!File.Exists(this.dbUser))
            {
                arqOpen = File.CreateText(this.dbUser);
                arqOpen.Close();
            }
            if (!File.Exists(this.dbVote))
            {
                arqOpen = File.CreateText(this.dbVote);
                arqOpen.Close();
            }


        }
        public static SingletonTXT getInstance()
        {
            return instance;
        }

        public User FindLogin(string login)
        {
            StreamReader arqOpen = File.OpenText(this.dbUser);
            string[] register;
            while (!arqOpen.EndOfStream)
            {
                register = arqOpen.ReadLine().Split(';');
                if (string.Equals(register[1], login))
                {
                    arqOpen.Close();
                    return new User(register[0], register[1], register[2]);
                }                                 
            }
            arqOpen.Close();
            return null;
        }

        public void CreateUser(User newUser)
        {
            StreamWriter arqOpen = File.AppendText(this.dbUser);
            arqOpen.WriteLine(newUser.name + ';' + newUser.getLogin() + ';' + newUser.getPass());
            arqOpen.Close();
        }        

        public List<string> VotesOfDay(DateTime date)
        {
            StreamReader arqOpen = File.OpenText(this.dbVote);
            List<string> votesOfDay = new List<string>();

            string[] register;
            while (!arqOpen.EndOfStream)
            {
                register = arqOpen.ReadLine().Split(';');
                if (string.Equals(register[0], date.ToString("dd/MM/yyyy")))
                    votesOfDay.Add(register[2]);
            }
            arqOpen.Close();
            return votesOfDay;
        }
        public List<string> UsersVotedOnDay(DateTime date)
        {
            StreamReader arqOpen = File.OpenText(this.dbVote);
            List<string> user = new List<string>();

            string[] register;
            while (!arqOpen.EndOfStream)
            {
                register = arqOpen.ReadLine().Split(';');
                if (string.Equals(register[0], date.ToString("dd/MM/yyyy")))
                {
                    if (string.IsNullOrEmpty(user.Find(element => element.Equals(register[1]))))
                        user.Add(register[1]);
                }
            }
            arqOpen.Close();
            return user;
        }

        public List<string> AllRestaurant()
        {
            StreamReader arqOpen = File.OpenText(this.dbVote);
            List<string> restaurant = new List<string>();

            string[] register;
            while (!arqOpen.EndOfStream)
            {
                register = arqOpen.ReadLine().Split(';');
                if (string.IsNullOrEmpty(restaurant.Find(element => element.Equals(register[2]))))
                    restaurant.Add(register[2]);
            }
            arqOpen.Close();
            return restaurant;
        }

        public void InsertVote(Vote newVote)
        {
            StreamWriter arqOpen = File.AppendText(this.dbVote);
            arqOpen.WriteLine(newVote.date.ToString("dd/MM/yyyy") + ';' + newVote.login + ';' + newVote.restaurant);
            arqOpen.Close();
        }
    }
}
