using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Spiritshackle : Move
{
	public override string Name => "Spirit Shackle";
	public override string Description => "The user attacks while also stitching the target's shadow to the ground to prevent it fleeing.";
	public override int BasePower => 80;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 100;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Ghost;
	public override bool IgnoresProtect => false;
	public Spiritshackle()
	{
		CurrentPowerPoints = PowerPoints;
	}
}