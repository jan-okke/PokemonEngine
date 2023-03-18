using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Flowershield : Move
	{
		public override string Name => "Flower Shield";
		public override string Description => "The user raises the Defense stats of all Grass-type Pokémon in battle with a mysterious power.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.AllBattlers;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Fairy;
		public Flowershield()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}