using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Oblivionwing : Move
	{
		public override string Name => "Oblivion Wing";
		public override string Description => "The user absorbs its target's HP. The user's HP is restored by over half of the damage dealt.";
		public override int BasePower => 80;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.Other;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Flying;
		public override bool IgnoresProtect => false;
		public Oblivionwing()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}