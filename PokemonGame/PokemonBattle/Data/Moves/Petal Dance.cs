using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Petaldance : Move
	{
		public override string Name => "Petal Dance";
		public override string Description => "The user attacks by scattering petals for two to three turns. The user then becomes confused.";
		public override int BasePower => 120;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.RandomNearFoe;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Grass;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public override bool IsDanceMove => true;
		public Petaldance()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}