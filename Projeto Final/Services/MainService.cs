using System.Collections.Generic;
using System.Linq;
using Projeto_Final.DAO;
using Projeto_Final.Models.Fighter;

namespace Projeto_Final.Services
{
    public class MainService
    {
        private List<Fighter> _ctrlList = new();
        private readonly Repo _repo = new();

        public void GetList(string id)
        {
            _ctrlList.Clear();
            _ctrlList = _repo.Find(id);
        }

        public void AgeRule()
        {
            _ctrlList.OrderByDescending(x => x.Age);
        }

        private double WinAverage(int score)
        {
            var victories = _ctrlList[score].Victories;
            var totalFights = _ctrlList[score].TotalFights;

            var average = (double)victories / totalFights * 100;

            return average;
        }

        private void TiebreakerRule(int score)
        {
            var fighter1 = _ctrlList[score];
            var fighter2 = _ctrlList[score + 1];

            var martialArtsF1 = fighter1.MartialArts;
            var martialArtsF2 = fighter2.MartialArts;

            var totalFightsF1 = fighter1.TotalFights;
            var totalFightsF2 = fighter2.TotalFights;
            
            if (totalFightsF1 > totalFightsF2)
            {
                _repo.SendVictories(fighter1);
                _repo.SendDefeats(fighter2);
                _ctrlList.Remove(fighter2);
            }
            else if (totalFightsF1 < totalFightsF2)
            {
                _repo.SendVictories(fighter2);
                _repo.SendDefeats(fighter1);
                _ctrlList.Remove(fighter1);
            }
            else
            {
                if (martialArtsF1 > martialArtsF2)
                {
                    _repo.SendVictories(fighter1);
                    _repo.SendDefeats(fighter2);
                    _ctrlList.Remove(fighter2);
                }
                else
                {
                    _repo.SendVictories(fighter2);
                    _repo.SendDefeats(fighter1);
                    _ctrlList.Remove(fighter1);
                }
            }
        }

        private void CombatCtrl(int score)
        {
            var fighter1 = _ctrlList[score];
            var fighter2 = _ctrlList[score + 1];
            var winAverageF1 = WinAverage(score);
            var winAverageF2 = WinAverage(score + 1);

            if (winAverageF1 == winAverageF2)
            {
                TiebreakerRule(score);
            }
            else if (winAverageF1 > winAverageF2)
            {
                _repo.SendVictories(fighter1);
                _repo.SendDefeats(fighter2);
                _ctrlList.Remove(fighter2);
            }
            else
            {
                _repo.SendVictories(fighter2);
                _repo.SendDefeats(fighter1);
                _ctrlList.Remove(fighter1);
            }
        }

        private void WinnersList()
        {
            var Winners = _ctrlList.Select(fighter => fighter.Id).ToList();

            var id = string.Join(",", Winners);
            GetList(id);
        }

        public int Tournament()
        {
            while (_ctrlList.Count > 1)
            {
                for (var i = 0; i < _ctrlList.Count; i++)
                {
                    CombatCtrl(i);
                }

                if (_ctrlList.Count > 4)
                {
                    WinnersList();
                    AgeRule();
                }
                else
                {
                    WinnersList();
                }
            }

            return (_ctrlList[0].Id);
        }
    }
}
