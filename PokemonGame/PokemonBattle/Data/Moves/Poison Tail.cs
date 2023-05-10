using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Poisontail : Move
{
	public override string Name => "Poison Tail";
	public override string Description => "The user hits the target with its tail. It may also poison the target. Critical hits land more easily.";
	public override int BasePower => 50;
	public override int PowerPoints => 25;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 10;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Poison;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool HasHighCriticalHitRate => true;
	public Poisontail()
	{
		CurrentPowerPoints = PowerPoints;
	}
}