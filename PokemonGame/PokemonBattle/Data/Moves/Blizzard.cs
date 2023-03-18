using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Blizzard : Move
	{
		public override string Name => "Blizzard";
		public override string Description => "A howling blizzard is summoned to strike the opposing team. It may also freeze them solid.";
		public override int BasePower => 110;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 70;
		public override int EffectChance => 10;
		public override MoveTarget Target => MoveTarget.AllNearFoes;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Ice;
		public override bool IgnoresProtect => false;
		public Blizzard()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}