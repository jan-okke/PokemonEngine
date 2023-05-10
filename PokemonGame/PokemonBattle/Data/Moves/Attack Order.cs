using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Attackorder : Move
{
	public override string Name => "Attack Order";
	public override string Description => "The user calls out its underlings to pummel the target. Critical hits land more easily.";
	public override int BasePower => 90;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Bug;
	public override bool IgnoresProtect => false;
	public override bool HasHighCriticalHitRate => true;
	public Attackorder()
	{
		CurrentPowerPoints = PowerPoints;
	}
}