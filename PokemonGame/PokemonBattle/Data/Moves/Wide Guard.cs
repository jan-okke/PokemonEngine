using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Wideguard : Move
{
	public override string Name => "Wide Guard";
	public override string Description => "The user and its allies are protected from wide-ranging attacks for a turn. May fail if used in succession.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 3;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.UserSide;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Rock;
	public Wideguard()
	{
		CurrentPowerPoints = PowerPoints;
	}
}