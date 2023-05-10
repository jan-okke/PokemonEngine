using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Multiattack : Move
{
	public override string Name => "Multi-Attack";
	public override string Description => "Cloaking itself in high energy, the user slams into the target. This move's type depends on the held memory.";
	public override int BasePower => 120;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Multiattack()
	{
		CurrentPowerPoints = PowerPoints;
	}
}