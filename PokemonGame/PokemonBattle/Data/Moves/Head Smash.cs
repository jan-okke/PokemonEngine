using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Headsmash : Move
{
	public override string Name => "Head Smash";
	public override string Description => "The user attacks the foe with a hazardous, full-power headbutt. The user also takes terrible damage.";
	public override int BasePower => 150;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 80;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Rock;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Headsmash()
	{
		CurrentPowerPoints = PowerPoints;
	}
}