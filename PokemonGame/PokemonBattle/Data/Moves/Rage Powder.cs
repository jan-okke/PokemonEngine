using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Ragepowder : Move
{
	public override string Name => "Rage Powder";
	public override string Description => "The user scatters irritating powder to draw attention to itself. Opponents aim only at the user.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 2;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Bug;
	public override bool IsPowderMove => true;
	public Ragepowder()
	{
		CurrentPowerPoints = PowerPoints;
	}
}