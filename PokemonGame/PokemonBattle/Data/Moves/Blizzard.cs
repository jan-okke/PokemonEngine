using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves
{
    public class Blizzard : Move
    {
        public override int BasePower => 110;
        public override string Description => "A snow storm woosh";
        public override MoveCategory Category => MoveCategory.Special;
        public override bool HasAdditionalEffect => true;
        public override string Name => "Blizzard";
        public override int PowerPoints => 5;
        public override int Priority => 0;
        public override PokemonType Type => PokemonType.Ice;

        public Blizzard() {
            CurrentPowerPoints = PowerPoints;
        }
    }
}