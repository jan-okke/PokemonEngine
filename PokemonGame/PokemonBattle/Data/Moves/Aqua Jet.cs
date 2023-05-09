using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Aquajet : Move
{
	public override string Name => "Aqua Jet";
	public override string Description => "The user lunges at the target at a speed that makes it almost invisible. It is sure to strike first.";
	public override int BasePower => 40;
	public override int PowerPoints => 20;
	public override int Priority => 1;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Water;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Aquajet()
	{
		CurrentPowerPoints = PowerPoints;
	}
}