using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Extensions
{
    public static class TerrainExtension
    {
        public static bool HasEffect(this Terrain terrain, TerrainEffect effect) => terrain.Effect == effect;
    }
}
