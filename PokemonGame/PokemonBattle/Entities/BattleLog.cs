using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Entities
{
    public class BattleLog
    {
        public Dictionary<string, string> Log { get; }

        public BattleLog()
        {
            Log = new Dictionary<string, string>();
        }
    }
}
