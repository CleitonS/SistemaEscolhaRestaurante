using SistemaVotacao.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVotacao
{
    interface ISingleton
    {
        
        User FindLogin(string login);
        void CreateUser(User newUser);
        List<string> VotesOfDay(DateTime date);
        List<string> UsersVotedOnDay(DateTime date);
        void InsertVote(Vote newVote);
        List<string> AllRestaurant();
    }
}
