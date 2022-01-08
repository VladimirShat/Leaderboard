using System.Collections.Generic;
using System.Linq;
using Storage;

namespace Leaderboard
{
    public class PlayerService
    {
        private readonly IRepository<Player> players;

        public PlayerService(IRepository<Player> players)
        {
            this.players = players;
        }

        public void Create(Player player)
        {
            players.Create(player);
        }

        public List<Player> GetPlayersSortedByPoints()
        {
            return players.GetAll().OrderByDescending(p => p.Points).ToList();
        }
    }
}
