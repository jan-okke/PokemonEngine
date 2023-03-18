using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Dragondarts : Move
	{
		public override string Name => "Dragon Darts";
		public override string Description => "The user attacks twice using Dreepy. If there are two targets, this move hits each one once.";
		public override int BasePower => 50;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Physical;
		public override PokemonType Type => PokemonType.Dragon;
		public override bool IgnoresProtect => false;
		public Dragondarts()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}