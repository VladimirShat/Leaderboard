using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Storage;

namespace Leaderboard
{
    [ApiController]
    [Route("")]
    public class PlayerController : ControllerBase
    {
        private readonly PlayerService playerService;

        public PlayerController(PlayerService playerService)
        {
            this.playerService = playerService;
        }

        [HttpPost]
        public void AddPlayer([FromBody] Player player)
        {
            playerService.Create(player);
        }

        [HttpGet]
        public List<Player> GetPlayersLeaderboard()
        {
            return playerService.GetPlayersSortedByPoints();
        }
    }
}
