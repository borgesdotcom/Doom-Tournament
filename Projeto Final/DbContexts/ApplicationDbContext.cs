using Microsoft.EntityFrameworkCore;
using Projeto_Final.Models.Fighter;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Final.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Fighter> Fighters { get; set; }

    }
}



