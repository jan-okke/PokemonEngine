using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Steelroller : Move
{
	public override string Name => "Steel Roller";
	public override string Description => "The user attacks while destroying the terrain. This move fails when the ground isn't a terrain.";
	public override int BasePower => 130;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Steel;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Steelroller()
	{
		CurrentPowerPoints = PowerPoints;
	}
}