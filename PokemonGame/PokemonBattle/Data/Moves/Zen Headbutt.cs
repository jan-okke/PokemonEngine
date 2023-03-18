using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Zenheadbutt : Move
	{
		public override string Name => "Zen Headbutt";
		public override string Description => "The user focuses its willpower to its head and attacks the foe. It may also make the target flinch.";
		public override int BasePower => 80;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 90;
		public override int EffectChance => 20;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Psychic;
		public override bool IsContactMove => true;
		public override bool IgnoresProtect => false;
		public Zenheadbutt()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}