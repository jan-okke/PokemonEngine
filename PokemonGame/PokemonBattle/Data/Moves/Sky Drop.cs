using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Skydrop : Move
{
	public override string Name => "Sky Drop";
	public override string Description => "The user takes the foe into the sky, then drops it on the next turn. The foe cannot attack while airborne.";
	public override int BasePower => 60;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.Other;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Flying;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Skydrop()
	{
		CurrentPowerPoints = PowerPoints;
	}
}