using Projeto_Final.DbContexts;
using System.Linq;

namespace Projeto_Final.Models.Fighter
{
    public static class FighterSeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Fighters.Any())
            {
                return;
            }

            context.Fighters.AddRange(
                new Fighter
                {
                    Name = "Doom Guy",
                    Age = 30,
                    MartialArts = 8,
                    TotalFights = 12,
                    Victories = 12,
                    Defeats = 0
                },
                new Fighter
                {
                    Name = "Spider Mastermind",
                    Age = 72,
                    MartialArts = 2,
                    TotalFights = 3,
                    Victories = 1,
                    Defeats = 2
                },
                new Fighter
                {
                    Name = "Icon of Sin",
                    Age = 2110,
                    MartialArts = 4,
                    TotalFights = 9,
                    Victories = 7,
                    Defeats = 2
                },
                new Fighter
                {
                    Name = "Cyberdemon",
                    Age = 22,
                    MartialArts = 1,
                    TotalFights = 4,
                    Victories = 2,
                    Defeats = 2
                },
                new Fighter
                {
                    Name = "Khan Maykr",
                    Age = 814,
                    MartialArts = 2,
                    TotalFights = 7,
                    Victories = 5,
                    Defeats = 2
                },
                new Fighter
                {
                    Name = "Guard",
                    Age = 143,
                    MartialArts = 1,
                    TotalFights = 5,
                    Victories = 2,
                    Defeats = 3
                },
                new Fighter
                {
                    Name = "Cacodemon",
                    Age = 811,
                    MartialArts = 3,
                    TotalFights = 15,
                    Victories = 6,
                    Defeats = 9
                },
                new Fighter
                {
                    Name = "Pinky",
                    Age = 43,
                    MartialArts = 2,
                    TotalFights = 9,
                    Victories = 5,
                    Defeats = 4
                },
                new Fighter
                {
                    Name = "Mancubus",
                    Age = 32,
                    MartialArts = 4,
                    TotalFights = 12,
                    Victories = 2,
                    Defeats = 10
                },
                new Fighter
                {
                    Name = "Imp",
                    Age = 21,
                    MartialArts = 1,
                    TotalFights = 10,
                    Victories = 1,
                    Defeats = 9
                },
                new Fighter
                {
                    Name = "Tyrant",
                    Age = 52,
                    MartialArts = 1,
                    TotalFights = 13,
                    Victories = 6,
                    Defeats = 7
                },
                new Fighter
                {
                    Name = "Prowler",
                    Age = 18,
                    MartialArts = 2,
                    TotalFights = 4,
                    Victories = 1,
                    Defeats = 3
                },
                new Fighter
                {
                    Name = "Harvester",
                    Age = 37,
                    MartialArts = 0,
                    TotalFights = 2,
                    Victories = 0,
                    Defeats = 2
                },
                new Fighter
                {
                    Name = "Summoner",
                    Age = 66,
                    MartialArts = 3,
                    TotalFights = 8,
                    Victories = 4,
                    Defeats = 4
                },
                new Fighter
                {
                    Name = "Hell Razer",
                    Age = 37,
                    MartialArts = 2,
                    TotalFights = 11,
                    Victories = 5,
                    Defeats = 6
                },
                new Fighter
                {
                    Name = "Gargoyle",
                    Age = 66,
                    MartialArts = 0,
                    TotalFights = 6,
                    Victories = 2,
                    Defeats = 4
                },
                new Fighter
                {
                    Name = "The Gladiator",
                    Age = 143,
                    MartialArts = 4,
                    TotalFights = 16,
                    Victories = 6,
                    Defeats = 10                    
                },
                new Fighter
                {
                    Name = "Marauder",
                    Age = 40,
                    MartialArts = 5,
                    TotalFights = 10,
                    Victories = 8,
                    Defeats = 2
                },
                new Fighter
                {
                    Name = "Whiplash",
                    Age = 20,
                    MartialArts = 3,
                    TotalFights = 9,
                    Victories = 6,
                    Defeats = 3
                },
                new Fighter
                {
                    Name = "Doom Hunter",
                    Age = 94,
                    MartialArts = 3,
                    TotalFights = 7,
                    Victories = 5,
                    Defeats = 2
                }
                );

            context.SaveChanges();
        }
    }
}
