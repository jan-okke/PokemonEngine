using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Entities
{
    public class BattleData
    {
        public Dictionary<string, object> Data { get; }

        public BattleData()
        {
            Data = new Dictionary<string, object>();
        }
    }
}
