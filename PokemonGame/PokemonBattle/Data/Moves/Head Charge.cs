using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Headcharge : Move
{
	public override string Name => "Head Charge";
	public override string Description => "The user charges its head into the foe, using its powerful guard hair. The user also takes damage.";
	public override int BasePower => 120;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Headcharge()
	{
		CurrentPowerPoints = PowerPoints;
	}
}