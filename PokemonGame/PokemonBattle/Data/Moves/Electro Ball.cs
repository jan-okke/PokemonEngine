using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Electroball : Move
	{
		public override string Name => "Electro Ball";
		public override string Description => "The user hurls an electric orb at the foe. It does more damage the faster the user is.";
		public override int BasePower => 1;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Electric;
		public override bool IgnoresProtect => false;
		public override bool IsBombMove => true;
		public Electroball()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}