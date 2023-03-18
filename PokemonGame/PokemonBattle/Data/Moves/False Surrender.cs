using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Falsesurrender : Move
	{
		public override string Name => "False Surrender";
		public override string Description => "The user pretends to bow its head, but then it stabs the target with its disheveled hair. Never misses.";
		public override int BasePower => 80;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Dark;
		public Falsesurrender()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}