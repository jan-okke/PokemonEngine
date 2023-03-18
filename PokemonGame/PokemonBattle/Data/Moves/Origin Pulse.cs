using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Originpulse : Move
	{
		public override string Name => "Origin Pulse";
		public override string Description => "The user attacks opposing Pokémon with countless beams of light that glow a deep and brilliant blue.";
		public override int BasePower => 110;
		public override int PowerPoints => 10;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Water;
		public Originpulse()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}