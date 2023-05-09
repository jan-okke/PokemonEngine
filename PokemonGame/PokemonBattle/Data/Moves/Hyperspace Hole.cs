using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Hyperspacehole : Move
{
	public override string Name => "Hyperspace Hole";
	public override string Description => "Using a hyperspace hole, the user appears right next to the target and strikes. Skips protections.";
	public override int BasePower => 80;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Psychic;
	public override bool CanMetronome => false;
	public Hyperspacehole()
	{
		CurrentPowerPoints = PowerPoints;
	}
}