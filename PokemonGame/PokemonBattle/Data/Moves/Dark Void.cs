using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Darkvoid : Move
	{
		public override string Name => "Dark Void";
		public override string Description => "Opposing Pokémon are dragged into a world of total darkness that makes them sleep.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 50;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.AllNearFoes;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Dark;
		public override bool IgnoresProtect => false;
		public Darkvoid()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}