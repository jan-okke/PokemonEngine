using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Pursuit : Move
{
	public override string Name => "Pursuit";
	public override string Description => "An attack move that inflicts double damage if used on a target that is switching out of battle.";
	public override int BasePower => 40;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Dark;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Pursuit()
	{
		CurrentPowerPoints = PowerPoints;
	}
}