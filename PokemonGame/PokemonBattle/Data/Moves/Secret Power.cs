using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Secretpower : Move
	{
		public override string Name => "Secret Power";
		public override string Description => "The user attacks with a secret power. Its added effects vary depending on the user's environment.";
		public override int BasePower => 70;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 30;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IgnoresProtect => false;
		public Secretpower()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}