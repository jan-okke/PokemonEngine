using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Entities
{
    public class BattleData
    {
        public Dictionary<string, string> Data { get; }

        public BattleData()
        {
            Data = new Dictionary<string, string>();
        }
    }
}
