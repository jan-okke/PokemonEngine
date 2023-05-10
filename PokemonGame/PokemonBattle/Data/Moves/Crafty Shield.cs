using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Craftyshield : Move
{
	public override string Name => "Crafty Shield";
	public override string Description => "The user protects itself and its allies from status moves with a mysterious power.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 3;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.UserSide;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Fairy;
	public Craftyshield()
	{
		CurrentPowerPoints = PowerPoints;
	}
}