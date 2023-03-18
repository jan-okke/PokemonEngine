using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Dragonbreath : Move
	{
		public override string Name => "Dragon Breath";
		public override string Description => "The user exhales a mighty gust that inflicts damage. It may also leave the target with paralysis.";
		public override int BasePower => 60;
		public override int PowerPoints => 20;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Dragon;
		public Dragonbreath()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}