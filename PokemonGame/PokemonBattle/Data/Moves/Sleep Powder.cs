using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Sleeppowder : Move
{
	public override string Name => "Sleep Powder";
	public override string Description => "The user scatters a big cloud of sleep-inducing dust around the target.";
	public override int BasePower => 0;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 75;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Grass;
	public override bool IgnoresProtect => false;
	public override bool IsPowderMove => true;
	public Sleeppowder()
	{
		CurrentPowerPoints = PowerPoints;
	}
}