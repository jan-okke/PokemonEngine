using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Powertrick : Move
	{
		public override string Name => "Power Trick";
		public override string Description => "The user employs its psychic power to switch its Attack with its Defense stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.User;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Psychic;
		public Powertrick()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}