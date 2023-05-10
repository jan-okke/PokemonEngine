using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Bounce : Move
{
	public override string Name => "Bounce";
	public override string Description => "The user bounces up high, then drops on the foe on the second turn. It may also paralyze the foe.";
	public override int BasePower => 85;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 85;
	public override int EffectChance => 30;
	public override MoveTarget Target => MoveTarget.Other;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Flying;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Bounce()
	{
		CurrentPowerPoints = PowerPoints;
	}
}