using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Gigadrain : Move
{
	public override string Name => "Giga Drain";
	public override string Description => "A nutrient-draining attack. The user's HP is restored by half the damage taken by the target.";
	public override int BasePower => 75;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Grass;
	public override bool IgnoresProtect => false;
	public Gigadrain()
	{
		CurrentPowerPoints = PowerPoints;
	}
}