using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Drainpunch : Move
{
	public override string Name => "Drain Punch";
	public override string Description => "An energy-draining punch. The user's HP is restored by half the damage taken by the target.";
	public override int BasePower => 75;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Fighting;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool IsPunchingMove => true;
	public Drainpunch()
	{
		CurrentPowerPoints = PowerPoints;
	}
}