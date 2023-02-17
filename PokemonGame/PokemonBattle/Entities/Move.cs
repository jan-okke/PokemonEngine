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

        public bool IsPhysical => Category == MoveCategory.Phsyical;
        public bool IsSpecial => Category == MoveCategory.Special;
        public bool IsStatus => Category == MoveCategory.Status;

        public bool IsRecoilMove => false; // TODO
        public bool IsPunchingMove => false; // TODO
        public bool IsContactMove => false; // TODO
        public bool IsSoundMove => false; // TODO
        public bool IsBitingMove => false; // TODO
        public bool IsAuraMove => false; // TODO
        public bool IsPulseMove => false; // TODO
        public bool IsSlasingMove => false; // TODO
        public bool IsZMove => false; // TODO
        public bool HurtsOnMiss => false; // TODO
        public bool HasAdditionalEffect => false; // TODO
        public bool HasExtraDamageOnMinimize => false; // TODO

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