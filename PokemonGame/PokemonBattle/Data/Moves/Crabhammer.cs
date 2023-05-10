using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Crabhammer : Move
{
	public override string Name => "Crabhammer";
	public override string Description => "The target is hammered with a large pincer. Critical hits land more easily.";
	public override int BasePower => 100;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Water;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool HasHighCriticalHitRate => true;
	public Crabhammer()
	{
		CurrentPowerPoints = PowerPoints;
	}
}