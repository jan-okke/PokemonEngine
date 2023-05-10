using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Sandtomb : Move
{
	public override string Name => "Sand Tomb";
	public override string Description => "The user traps the target inside a harshly raging sandstorm for four to five turns.";
	public override int BasePower => 35;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 85;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Ground;
	public override bool IgnoresProtect => false;
	public Sandtomb()
	{
		CurrentPowerPoints = PowerPoints;
	}
}