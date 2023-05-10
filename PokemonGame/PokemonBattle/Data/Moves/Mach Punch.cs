using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Machpunch : Move
{
	public override string Name => "Mach Punch";
	public override string Description => "The user throws a punch at blinding speed. It is certain to strike first.";
	public override int BasePower => 40;
	public override int PowerPoints => 30;
	public override int Priority => 1;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Fighting;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool IsPunchingMove => true;
	public Machpunch()
	{
		CurrentPowerPoints = PowerPoints;
	}
}