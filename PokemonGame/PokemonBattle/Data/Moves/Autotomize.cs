using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Autotomize : Move
	{
		public override string Name => "Autotomize";
		public override string Description => "The user sheds part of its body to make itself lighter and sharply raise its Speed stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.User;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Steel;
		public Autotomize()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}