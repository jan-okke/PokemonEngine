using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Needlearm : Move
{
	public override string Name => "Needle Arm";
	public override string Description => "The user attacks by wildly swinging its thorny arms. It may also make the target flinch.";
	public override int BasePower => 60;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 30;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Grass;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Needlearm()
	{
		CurrentPowerPoints = PowerPoints;
	}
}