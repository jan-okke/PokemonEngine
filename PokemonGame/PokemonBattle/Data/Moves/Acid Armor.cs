using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Acidarmor : Move
	{
		public override string Name => "Acid Armor";
		public override string Description => "The user alters its cellular structure to liquefy itself, sharply raising its Defense stat.";
		public override int BasePower => 0;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override int Accuracy => 0;
		public override int EffectChance => 0;
		public override MoveTarget Target => MoveTarget.User;
		public override MoveCategory Category => MoveCategory.Status;
		public override PokemonType Type => PokemonType.Poison;
		public Acidarmor()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}