using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Happyhour : Move
{
	public override string Name => "Happy Hour";
	public override string Description => "Using Happy Hour doubles the amount of prize money received after battle.";
	public override int BasePower => 0;
	public override int PowerPoints => 30;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.UserSide;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public Happyhour()
	{
		CurrentPowerPoints = PowerPoints;
	}
}