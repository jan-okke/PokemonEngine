using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Stormthrow : Move
{
	public override string Name => "Storm Throw";
	public override string Description => "The user strikes the target with a fierce blow. This attack always results in a critical hit.";
	public override int BasePower => 60;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Fighting;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Stormthrow()
	{
		CurrentPowerPoints = PowerPoints;
	}
}