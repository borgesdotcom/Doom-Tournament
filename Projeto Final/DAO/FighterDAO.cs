
using Projeto_Final.Models;
using Microsoft.Data.SqlClient;
using Projeto_Final.Models.Fighter;
using System.Collections.Generic;

namespace Projeto_Final.DAO
{
    public class FighterDAO
    {
        public static List<Fighter> ListFighters(string query)
        {
            using var connection = ConnectDB.Connection();
            using var command = new SqlCommand(query, connection);
            SqlDataReader read = command.ExecuteReader();
            
            List<Fighter> fighters = new();

            while (read.Read())
            {
                Fighter fighter = new Fighter();

                fighter.Id = int.Parse(read["Id"].ToString());
                fighter.Name = read["Name"].ToString();
                fighter.Age = int.Parse(read["Age"].ToString());
                fighter.MartialArts = int.Parse(read["MartialArts"].ToString());
                fighter.TotalFights = int.Parse(read["TotalFights"].ToString());
                fighter.Victories = int.Parse(read["Victories"].ToString());
                fighter.Defeats = int.Parse(read["Defeats"].ToString());
                        
                fighters.Add(fighter);
            }

            return fighters;
        }

        public static void UpdateVictories(string query, Fighter fighter)
        {
            using (var connection = ConnectDB.Connection())
            {
                using (var command = new SqlCommand(query, connection))
                {
                    var attVictories = fighter.Victories + 1;
                    var attTotalFights = fighter.TotalFights + 1;

                    command.Parameters.AddWithValue("@Victories", attVictories);
                    command.Parameters.AddWithValue("@TotalFights", attTotalFights);

                    command.ExecuteNonQuery();
                }
            }
            
        }

        public static void UpdateDefeats(string query, Fighter fighter)
        {
            using (var connection = ConnectDB.Connection())
            {
                using (var command = new SqlCommand(query, connection))
                {
                    var attDefeats = fighter.Defeats + 1;
                    var attTotalFights = fighter.TotalFights + 1;

                    command.Parameters.AddWithValue("@Defeats", attDefeats);
                    command.Parameters.AddWithValue("@TotalFights", attTotalFights);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

        
