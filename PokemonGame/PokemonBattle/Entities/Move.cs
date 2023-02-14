using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Entities 
{
    public class Move 
    {
        public int BasePower { get; set; }
        public string Name { get; set; }
        public int PowerPoints { get; set; }
        public PokemonType Type { get; set; }
        public MoveCategory Category { get; set; }

        public Move(string name, int basePower, int powerPoints, PokemonType type, MoveCategory category) 
        {
            Name = name;
            BasePower = basePower;
            PowerPoints = powerPoints;
            Type = type;
            Category = category;
        }
    }
}