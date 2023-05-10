using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Feint : Move
{
	public override string Name => "Feint";
	public override string Description => "An attack that hits a target using Protect or Detect. It also lifts the effects of those moves.";
	public override int BasePower => 30;
	public override int PowerPoints => 10;
	public override int Priority => 2;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public Feint()
	{
		CurrentPowerPoints = PowerPoints;
	}
}