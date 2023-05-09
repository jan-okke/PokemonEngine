using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Furycutter : Move
{
	public override string Name => "Fury Cutter";
	public override string Description => "The target is slashed with scythes or claws. Its power increases if it hits in succession.";
	public override int BasePower => 40;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 95;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Bug;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Furycutter()
	{
		CurrentPowerPoints = PowerPoints;
	}
}