using BillyGameCenter.Models;

namespace BillyGameCenter.DataAccess
{
    public interface IPlayerInfoRepository
    {
        Task<List<PlayerInfoEntity>> GetAllPaterInfoAsync();
    }
}