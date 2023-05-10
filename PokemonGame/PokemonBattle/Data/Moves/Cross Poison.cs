using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Crosspoison : Move
{
	public override string Name => "Cross Poison";
	public override string Description => "A slashing attack with a poisonous blade that may also poison the foe. Critical hits land more easily.";
	public override int BasePower => 70;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 10;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Poison;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool HasHighCriticalHitRate => true;
	public Crosspoison()
	{
		CurrentPowerPoints = PowerPoints;
	}
}