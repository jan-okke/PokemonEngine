using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Sparklingaria : Move
	{
		public override string Name => "Sparkling Aria";
		public override string Description => "The user bursts into song, emitting many bubbles. Any burnt Pokémon will be healed by these bubbles.";
		public override int BasePower => 90;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 100;
		public override MoveTarget Target => MoveTarget.AllNearOthers;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Water;
		public override bool IgnoresProtect => false;
		public override bool IsSoundMove => true;
		public Sparklingaria()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}