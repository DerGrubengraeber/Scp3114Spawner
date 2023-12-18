
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace Scp3114Spawner___EXILED
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("The minimum amount of players on the Server to allow SCP3114 to spawn. Default 1")]
        public int MinPlayers { get; set; } = 1;

        [Description("Set to true to make the Plugin change a Class D to SCP3114 instead of an SCP. Default false")]
        public bool SpawnOnTop { get; set; } = false;

        [Description("The minimum amount of players on the Server to allow SCP3114 to spawn on top (only applies when SpawnOnTop is set to true, does not overwrite MinPlayers). Default 0")]
        public int MinPlayersForOnTop { get; set; } = 0;

        [Description("The chance for SCP3114 to spawn in %. Valid values are 0-100. Default 30")]
        public int SpawnChance { get; set; } = 30;
    }
}
