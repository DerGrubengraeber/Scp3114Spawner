using System;
using System.Collections.Generic;
using System.Linq;
using Exiled.API.Features;

namespace Scp3114Spawner___EXILED
{
    class EventHandler
    {
        private static Config config => Scp3114Spawner.Instance.Config;


        private Random rnd = new Random();
        private int rndN;
        private static List<Player> TBC;
       

        public EventHandler()
        {
            Exiled.Events.Handlers.Server.RoundStarted += RoundStart;
        }
        ~EventHandler()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= RoundStart;
        }

        public void RoundStart()
        {
            if(Player.List.Count >= config.MinPlayers && rnd.Next(0, 100) <= config.SpawnChance)
            {
                rndN = rnd.Next(0, Player.Get(PlayerRoles.Team.SCPs).Count());
                if(config.SpawnOnTop && Player.List.Count >= config.MinPlayersForOnTop)
                {
                    TBC = new List<Player>(Player.Get(PlayerRoles.Team.ClassD));
                    ChangePlayer(TBC[rndN]);
                }
                else
                {
                    TBC = new List<Player>(Player.Get(PlayerRoles.Team.SCPs));
                    ChangePlayer(TBC[rndN]);
                }
            }
        }

        public void ChangePlayer(Player player)
        {
            player.Role.Set(PlayerRoles.RoleTypeId.Scp3114);
        }
    }
}
