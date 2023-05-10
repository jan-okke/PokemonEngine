using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Iciclecrash : Move
{
	public override string Name => "Icicle Crash";
	public override string Description => "The user attacks by harshly dropping an icicle onto the foe. It may also make the target flinch.";
	public override int BasePower => 85;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 30;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Ice;
	public override bool IgnoresProtect => false;
	public Iciclecrash()
	{
		CurrentPowerPoints = PowerPoints;
	}
}