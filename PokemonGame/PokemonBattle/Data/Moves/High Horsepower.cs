using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Highhorsepower : Move
{
	public override string Name => "High Horsepower";
	public override string Description => "The user fiercely attacks the target using its entire body.";
	public override int BasePower => 95;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 95;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Ground;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Highhorsepower()
	{
		CurrentPowerPoints = PowerPoints;
	}
}