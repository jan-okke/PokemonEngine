using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Gunkshot : Move
{
	public override string Name => "Gunk Shot";
	public override string Description => "The user shoots filthy garbage at the target to attack. It may also poison the target.";
	public override int BasePower => 120;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 80;
	public override int EffectChance => 30;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Poison;
	public override bool IgnoresProtect => false;
	public Gunkshot()
	{
		CurrentPowerPoints = PowerPoints;
	}
}