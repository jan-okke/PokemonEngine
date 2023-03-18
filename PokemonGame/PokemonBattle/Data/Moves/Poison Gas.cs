using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Poisongas : Move
	{
		public override string Name => "Poison Gas";
		public override string Description => "A cloud of poison gas is sprayed in the face of opposing Pokémon. It may poison those hit.";
		public override int BasePower => 0;
		public override int PowerPoints => 40;
		public override int Priority => 0;
		public override int Accuracy => 90;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.AllNearFoes;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Poison;
		public override bool IgnoresProtect => false;
		public Poisongas()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}