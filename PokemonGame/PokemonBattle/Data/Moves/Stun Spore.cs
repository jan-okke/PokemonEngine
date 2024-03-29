using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Stunspore : Move
{
	public override string Name => "Stun Spore";
	public override string Description => "The user scatters a cloud of paralyzing powder. It may leave the target with paralysis.";
	public override int BasePower => 0;
	public override int PowerPoints => 30;
	public override int Priority => 0;
	public override int Accuracy => 75;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Grass;
	public override bool IgnoresProtect => false;
	public override bool IsPowderMove => true;
	public Stunspore()
	{
		CurrentPowerPoints = PowerPoints;
	}
}