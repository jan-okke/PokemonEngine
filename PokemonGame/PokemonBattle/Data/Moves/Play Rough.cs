using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Playrough : Move
{
	public override string Name => "Play Rough";
	public override string Description => "The user plays rough with the target and attacks it. This may also lower the target's Attack stat.";
	public override int BasePower => 90;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 10;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Fairy;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Playrough()
	{
		CurrentPowerPoints = PowerPoints;
	}
}