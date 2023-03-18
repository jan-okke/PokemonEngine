using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Leer : Move
	{
		public override string Name => "Leer";
		public override string Description => "The user gains an intimidating leer with sharp eyes. The target's Defense stat is reduced.";
		public override int BasePower => 0;
		public override int PowerPoints => 30;
		public override int Priority => 0;
		public override int Accuracy => 100;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.AllNearFoes;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Normal;
		public override bool IgnoresProtect => false;
		public Leer()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}