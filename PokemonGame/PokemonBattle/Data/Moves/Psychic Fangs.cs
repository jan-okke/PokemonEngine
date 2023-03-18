using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Psychicfangs : Move
	{
		public override string Name => "Psychic Fangs";
		public override string Description => "The user bites the target using psychic capabilities. This can also destroy Light Screen and Reflect.";
		public override int BasePower => 85;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Psychic;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public override bool IsBitingMove => true;
		public Psychicfangs()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}