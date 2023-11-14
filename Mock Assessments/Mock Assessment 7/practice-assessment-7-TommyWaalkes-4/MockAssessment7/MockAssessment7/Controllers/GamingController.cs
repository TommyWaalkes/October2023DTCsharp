using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MockAssessment7.Models;

namespace MockAssessment7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamingController : ControllerBase
    {
        GameDB DB = new GameDB();

        [HttpGet("Classes")]
        public List<PlayerClass> GetAllClasses()
        {
            return DB.PlayerClasses;
        }

        [HttpGet("Players")]
        public List<Player> GetAllPlayers()
        {
            return DB.Players;
        }

        [HttpGet("MinLevel/{level}")]
        public List<Player> PlayersGetMinLevel(int level)
        {
            List<Player> players = DB.Players.Where(p=>p.Level>=level).ToList();
            return players;
        }

        [HttpGet("PlayersSortLevel")]
        public List<Player> PlayersSortLevel()
        {
            List<Player> players = DB.Players.OrderByDescending(p=>p.Level).ToList();
            return players;
        }

        [HttpGet("GetPlayersByClass/{Class}")]
        public List<Player> GetPlayersByClass(string Class)
        {
            //Assume each player class only appears once
            PlayerClass pc = DB.PlayerClasses.Where(c=>c.Name==Class).First();

            List<Player> players = DB.Players.Where(p => p.PlayerClassId == pc.ID).ToList();
            return players;
        }

        [HttpGet("PlayersOfType/{type}")]
        public List<Player> PlayersOfType(string type)
        {
            List<PlayerClass> pTypes = DB.PlayerClasses.Where(p => p.Type == type).ToList();
            List<Player> players = new List<Player>();
            foreach(PlayerClass pc in pTypes) {
                players.AddRange( DB.Players.Where(p => p.PlayerClassId == pc.ID).ToList());
            }
            return players;
        }

        [HttpGet("AllPlayedClasses")]
        public List<PlayerClass> AllPlayedClasses()
        {
            List<Player> players = DB.Players;
            List<PlayerClass> pcs = new List<PlayerClass>();

            for(int i = 0; i < players.Count; i++)
            {
                Player p = players[i];
                PlayerClass Class = DB.PlayerClasses.Where(pc => pc.ID == p.PlayerClassId).First();
                if (!pcs.Contains(Class))
                {
                    pcs.Add(Class);
                }
            }

            return pcs;

        }
    }
}
