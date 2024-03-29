using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Extremespeed : Move
{
	public override string Name => "Extreme Speed";
	public override string Description => "The user charges the target at blinding speed. This attack always goes before any other move.";
	public override int BasePower => 80;
	public override int PowerPoints => 5;
	public override int Priority => 2;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Extremespeed()
	{
		CurrentPowerPoints = PowerPoints;
	}
}