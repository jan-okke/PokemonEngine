using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Shellsidearm : Move
{
	public override string Name => "Shell Side Arm";
	public override string Description => "Inflicts physical or special damage, whichever will be more effective. May also poison the target.";
	public override int BasePower => 90;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 20;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Poison;
	public override bool IgnoresProtect => false;
	public Shellsidearm()
	{
		CurrentPowerPoints = PowerPoints;
	}
}