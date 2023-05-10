using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Stoneedge : Move
{
	public override string Name => "Stone Edge";
	public override string Description => "The user stabs the foe with sharpened stones from below. It has a high critical-hit ratio.";
	public override int BasePower => 100;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 80;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Rock;
	public override bool IgnoresProtect => false;
	public override bool HasHighCriticalHitRate => true;
	public Stoneedge()
	{
		CurrentPowerPoints = PowerPoints;
	}
}