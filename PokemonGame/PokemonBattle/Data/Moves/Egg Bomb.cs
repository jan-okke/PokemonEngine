using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Eggbomb : Move
{
	public override string Name => "Egg Bomb";
	public override string Description => "A large egg is hurled at the target with maximum force to inflict damage.";
	public override int BasePower => 100;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 75;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public override bool IsBombMove => true;
	public Eggbomb()
	{
		CurrentPowerPoints = PowerPoints;
	}
}