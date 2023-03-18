using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Tearfullook : Move
	{
		public override string Name => "Tearful Look";
		public override string Description => "Gets teary eyed to make the target lose its will to fight. Lowers the target's Attack and Sp. Atk.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public Tearfullook()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}