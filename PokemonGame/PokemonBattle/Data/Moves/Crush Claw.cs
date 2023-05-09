using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Crushclaw : Move
{
	public override string Name => "Crush Claw";
	public override string Description => "The user slashes the target with hard and sharp claws. It may also lower the target's Defense.";
	public override int BasePower => 75;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 95;
	public override int EffectChance => 50;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Crushclaw()
	{
		CurrentPowerPoints = PowerPoints;
	}
}