using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Futuresight : Move
	{
		public override string Name => "Future Sight";
		public override string Description => "Two turns after this move is used, a hunk of psychic energy attacks the target.";
		public override int BasePower => 120;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.NearOther;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Psychic;
		public Futuresight()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}