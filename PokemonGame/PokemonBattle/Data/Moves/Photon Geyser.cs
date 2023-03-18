using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Photongeyser : Move
	{
		public override string Name => "Photon Geyser";
		public override string Description => "The user attacks with a pillar of light. This move the higher of the user's Attack or Sp. Atk stat.";
		public override int BasePower => 100;
		public override int PowerPoints => 5;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Psychic;
		public override bool IgnoresProtect => false;
		public override bool CanMetronome => false;
		public Photongeyser()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}