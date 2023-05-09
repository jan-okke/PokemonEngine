using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Dualchop : Move
{
	public override string Name => "Dual Chop";
	public override string Description => "The user attacks its target by hitting it with brutal strikes. The target is hit twice in a row.";
	public override int BasePower => 40;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Dragon;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Dualchop()
	{
		CurrentPowerPoints = PowerPoints;
	}
}