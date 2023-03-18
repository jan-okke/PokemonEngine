using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Fierywrath : Move
	{
		public override string Name => "Fiery Wrath";
		public override string Description => "The user transforms its wrath into a fire-like aura to attack. This may also make foes flinch.";
		public override int BasePower => 90;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Dark;
		public Fierywrath()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}