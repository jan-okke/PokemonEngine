using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Rockthrow : Move
{
	public override string Name => "Rock Throw";
	public override string Description => "The user picks up and throws a small rock at the target to attack.";
	public override int BasePower => 50;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Rock;
	public override bool IgnoresProtect => false;
	public Rockthrow()
	{
		CurrentPowerPoints = PowerPoints;
	}
}