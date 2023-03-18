using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Icefang : Move
	{
		public override string Name => "Ice Fang";
		public override string Description => "The user bites with cold-infused fangs. It may also make the target flinch or leave it frozen.";
		public override int BasePower => 65;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 95;
		public override int EffectChance => 100;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Ice;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public override bool IsBitingMove => true;
		public Icefang()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}