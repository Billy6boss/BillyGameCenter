using BillyGameCenter.Models;
using Microsoft.EntityFrameworkCore;

namespace BillyGameCenter.DataAccess
{
    public class RepositoryBase : DbContext
    {
        public RepositoryBase(DbContextOptions<RepositoryBase> options) : base(options)
        {
        }

        private DbSet<PlayerInfoEntity> PlayerInfo { get; set; }
    }
}