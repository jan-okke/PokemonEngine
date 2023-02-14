using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Extensions 
{
    public static class StatsExtension 
    {
        public static int Sum(this Stats stats) 
        {
            return stats.HP + stats.Attack + stats.Defense + stats.SpecialAttack + stats.SpecialDefense + stats.Speed;
        }
        public static double Avg(this Stats stats) 
        {
            return stats.Sum() / 6;
        }
    }
}