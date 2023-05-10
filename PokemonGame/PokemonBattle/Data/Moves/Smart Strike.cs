using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Smartstrike : Move
{
	public override string Name => "Smart Strike";
	public override string Description => "The user stabs the target with a sharp horn. This attack never misses.";
	public override int BasePower => 70;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Steel;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Smartstrike()
	{
		CurrentPowerPoints = PowerPoints;
	}
}