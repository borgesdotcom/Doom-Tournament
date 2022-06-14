using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_Final.DAO;
using Projeto_Final.DbContexts;
using Projeto_Final.Models.Fighter;
using Projeto_Final.Services;

namespace Projeto_Final.Controllers
{
    public class TournamentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TournamentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tournament
        public async Task<IActionResult> Start()
        {
            var fighters = _context.Fighters;
            
            await Task.Delay(6600);
            return View(fighters);
        }

        [Route("/Winner/{winnerId}")]
        public async Task<IActionResult> Winner(string winnerId)
        {
            var repo = new Repo();
            var winner = repo.Find(winnerId)[0];
            await Task.Delay(1500);
            return View(winner);
        }

        public JsonResult Draft([FromBody] string targetId)
        {
            var tournamentService = new MainService();
            tournamentService.GetList(targetId);
            tournamentService.AgeRule();
            var winner = tournamentService.Tournament();
            return Json(new {url = $"/Winner/{winner}"});
        }
    }
}
