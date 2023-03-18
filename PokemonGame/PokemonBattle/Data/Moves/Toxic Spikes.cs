using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Toxicspikes : Move
	{
		public override string Name => "Toxic Spikes";
		public override string Description => "The user lays a trap of poison spikes at the foe's feet. They poison foes that switch into battle.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.FoeSide;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Poison;
		public Toxicspikes()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}