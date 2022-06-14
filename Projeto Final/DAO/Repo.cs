using System.Collections.Generic;
using Projeto_Final.Models.Fighter;


namespace Projeto_Final.DAO
{
    public class Repo
    {
        public List<Fighter> Find(string id)
        {
            string query =
                $"SELECT Id, Name, Age, MartialArts, TotalFights, Victories, Defeats FROM Fighters WHERE Id in ({id})";

            return FighterDAO.ListFighters(query);
        }

        public void SendVictories(Fighter fighter)
        {
            string query =
                $"UPDATE Fighters SET Victories = @Victories,TotalFights = @TotalFights where Id = {fighter.Id}";

            FighterDAO.UpdateVictories(query, fighter);
        }

        public void SendDefeats(Fighter fighter)
        {
            string query = $"UPDATE Fighters SET Defeats = @Defeats,TotalFights = @TotalFights where Id = {fighter.Id}";

            FighterDAO.UpdateDefeats(query, fighter);
        }

    }
}
