using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Electroweb : Move
	{
		public override string Name => "Electroweb";
		public override string Description => "The user captures and attacks foes by using an electric net, which lowers their Speed stat.";
		public override int BasePower => 55;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 95;
		public override int EffectChance => 100;
		public override MoveTarget Target => MoveTarget.AllNearFoes;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Electric;
		public override bool IgnoresProtect => false;
		public Electroweb()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}