using SistemaVotacao.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVotacao.Model
{
    class VoteModel
    {
        public Dictionary<string, int> VotesOfDay(DateTime date)
        {
            ISingleton instSingle = SingletonTXT.getInstance();
            Dictionary<string, int> countVotes = new Dictionary<string, int>();
            List<string> votes = instSingle.VotesOfDay(date);
            
            foreach (string element in votes.Distinct())
            {
                int cont = 0;
                foreach (string iterator in votes)
                {
                    if (string.Equals(element, iterator))
                        cont++;
                }
                countVotes.Add(element, cont);
            }
            return countVotes;
        }

        public List<string> GetAllRestaurant()
        {
            ISingleton instSingle = SingletonTXT.getInstance();
            return instSingle.AllRestaurant();

        }

        public string RestaurantOfDay(DateTime date)
        {
            Dictionary<string, int> votacionOfDay = VotesOfDay(date).OrderByDescending(elem => elem.Value).ToDictionary(elem1 => elem1.Key, elem2 => elem2.Value);
            DateTime beginWeek = date.AddDays(- date.DayOfWeek.GetHashCode());

            for (DateTime iterator = beginWeek; iterator.CompareTo(date) < 0; iterator = iterator.AddDays(1))
            {
                string restToRemove = this.RestaurantOfDay(iterator);
                if(!string.IsNullOrEmpty(restToRemove))
                    votacionOfDay.Remove(restToRemove);
            }
            if (votacionOfDay.Count == 0)
                return null;
            else
                return votacionOfDay.First().Key;
        }


        public void Vote(Vote newVote)
        {
            if (string.IsNullOrEmpty(newVote.restaurant))
                throw new Exception("Restaurante inválido!");

            ISingleton instSingle = SingletonTXT.getInstance();
            if(!string.IsNullOrEmpty(instSingle.UsersVotedOnDay(newVote.date).Find(element => element.Contains(newVote.login))))
                throw new Exception("Usuário já votou neste dia!");

            instSingle.InsertVote(newVote);


        }
    }
}

