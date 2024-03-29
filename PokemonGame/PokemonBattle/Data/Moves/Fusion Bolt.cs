using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Fusionbolt : Move
{
	public override string Name => "Fusion Bolt";
	public override string Description => "The user throws down a giant thunderbolt. It does more damage if influenced by an enormous flame.";
	public override int BasePower => 100;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Electric;
	public override bool IgnoresProtect => false;
	public Fusionbolt()
	{
		CurrentPowerPoints = PowerPoints;
	}
}