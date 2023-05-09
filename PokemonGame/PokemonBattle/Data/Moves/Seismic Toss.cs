using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Seismictoss : Move
{
	public override string Name => "Seismic Toss";
	public override string Description => "The target is thrown using the power of gravity. It inflicts damage equal to the user's level.";
	public override int BasePower => 1;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Fighting;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Seismictoss()
	{
		CurrentPowerPoints = PowerPoints;
	}
}