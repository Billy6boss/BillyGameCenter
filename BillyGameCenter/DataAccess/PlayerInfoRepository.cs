using BillyGameCenter.Models;

namespace BillyGameCenter.DataAccess
{
    public class PlayerInfoRepository : IPlayerInfoRepository
    {
        public PlayerInfoRepository()
        {
            
        }

        public Task<List<PlayerInfoEntity>> GetAllPaterInfoAsync()
        {
            throw new NotImplementedException();
        }
    }
}