using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Tailwhip : Move
	{
		public override string Name => "Tail Whip";
		public override string Description => "The user wags its tail cutely, making opposing Pokémon less wary and lowering their Defense stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 30;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.AllNearFoes;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IgnoresProtect => false;
		public Tailwhip()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}