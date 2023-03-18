using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Earthquake : Move
	{
		public override string Name => "Earthquake";
		public override string Description => "The user sets off an earthquake that strikes every Pokémon around it.";
		public override int BasePower => 100;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.AllNearOthers;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ground;
		public override bool IgnoresProtect => false;
		public Earthquake()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}