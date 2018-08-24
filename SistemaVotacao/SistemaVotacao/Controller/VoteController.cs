using SistemaVotacao.Dominio;
using SistemaVotacao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVotacao.Controller
{
    class VoteController
    {
        public string RestaurantOfDay(DateTime date)
        {
            VoteModel vModel = new VoteModel();
            return vModel.RestaurantOfDay(date);        
        }

        public int VotesOfRestaurantOnDay(DateTime date, string restaurant)
        {
            VoteModel vModel = new VoteModel();
            return vModel.VotesOfDay(date).FirstOrDefault(elem => elem.Key.Equals(restaurant)).Value;            
        }
        public List<string> GetAllRestaurant()
        {
            VoteModel vModel = new VoteModel();
            return vModel.GetAllRestaurant();

        }

        public string Vote(DateTime date, string login, string restaurant)
        {
            VoteModel vModel = new VoteModel();
            Vote vote = new Vote(restaurant, date, login);
            try
            {
                vModel.Vote(vote);
            }catch(Exception except) { return except.Message; }

            return "Voto inserido com sucesso!";
        }
    }
}
