using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;

namespace Scp3114Spawner___EXILED
{
    public class Scp3114Spawner : Plugin<Config>
    {
        public override string Name => "SCP3114 Spawner";
        public override string Prefix => "3113Spawner";
        public override string Author => "@DerGrubengraeber";

        private EventHandler eventHandler { get; set; }
        public static Scp3114Spawner Instance { get; private set; }
        public override void OnEnabled()
        {
            Instance = this;
            eventHandler = new EventHandler();
            base.OnEnabled();
        }
        public override void OnDisabled() //TODO
        {
            base.OnDisabled();
        }

    }
}
