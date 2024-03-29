using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Doublehit : Move
{
	public override string Name => "Double Hit";
	public override string Description => "The user slams the target with a long tail, vines, or tentacle. The target is hit twice in a row.";
	public override int BasePower => 35;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Doublehit()
	{
		CurrentPowerPoints = PowerPoints;
	}
}