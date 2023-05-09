using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Poweruppunch : Move
{
	public override string Name => "Power-Up Punch";
	public override string Description => "Striking opponents repeatedly makes the user's fists harder, raising the user's Attack stat.";
	public override int BasePower => 40;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 100;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Fighting;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool IsPunchingMove => true;
	public Poweruppunch()
	{
		CurrentPowerPoints = PowerPoints;
	}
}