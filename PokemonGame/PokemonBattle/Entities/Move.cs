using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Entities 
{
    public class Move 
    {
        public virtual int BasePower { get; }
        public virtual string Name { get; }
        public virtual int PowerPoints { get; }
        public virtual PokemonType Type { get; }
        public virtual MoveCategory Category { get; }
        public virtual int Priority { get; }

        public int CurrentPowerPoints { get; internal set; }

        public bool IsPhysical => Category == MoveCategory.Phsyical;
        public bool IsSpecial => Category == MoveCategory.Special;
        public bool IsStatus => Category == MoveCategory.Status;

        public virtual bool IsRecoilMove => false; // TODO
        public virtual bool IsPunchingMove => false; // TODO
        public virtual bool IsContactMove => false; // TODO
        public virtual bool IsSoundMove => false; // TODO
        public virtual bool IsBitingMove => false; // TODO
        public virtual bool IsAuraMove => false; // TODO
        public virtual bool IsPulseMove => false; // TODO
        public virtual bool IsSlasingMove => false; // TODO
        public virtual bool IsZMove => false; // TODO
        public virtual bool HurtsOnMiss => false; // TODO
        public virtual bool HasAdditionalEffect => false; // TODO
        public virtual bool HasExtraDamageOnMinimize => false; // TODO
        public virtual bool IgnoresProtect => false; // TODO
        public Move(string name, int basePower, int powerPoints, PokemonType type, MoveCategory category) 
        {
            Name = name;
            BasePower = basePower;
            PowerPoints = powerPoints;
            CurrentPowerPoints = powerPoints; // set to full 
            Type = type;
            Category = category;
            Priority = 0;
        }
        public Move() {}
    }
}