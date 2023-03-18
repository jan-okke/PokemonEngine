using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves
{
	public class Echoedvoice : Move
	{
		public override string Name => "Echoed Voice";
		public override string Description => "The user attacks the foe with an echoing voice. If this move is used every turn, it does greater damage.";
		public override int BasePower => 40;
		public override int PowerPoints => 15;
		public override int Priority => 0;
		public override MoveCategory Category => MoveCategory.Special;
		public override PokemonType Type => PokemonType.Normal;
		public Echoedvoice()
		{
			CurrentPowerPoints = PowerPoints;
		}
	}
}