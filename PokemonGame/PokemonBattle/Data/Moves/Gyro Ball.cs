using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Gyroball : Move
{
	public override string Name => "Gyro Ball";
	public override string Description => "The user tackles the target with a high-speed spin. The slower the user, the greater the damage.";
	public override int BasePower => 1;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Steel;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool IsBombMove => true;
	public Gyroball()
	{
		CurrentPowerPoints = PowerPoints;
	}
}