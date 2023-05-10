using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Snipeshot : Move
{
	public override string Name => "Snipe Shot";
	public override string Description => "The user ignores any effects that redirect moves, allowing this move to hit the chosen target.";
	public override int BasePower => 80;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Water;
	public override bool IgnoresProtect => false;
	public override bool HasHighCriticalHitRate => true;
	public Snipeshot()
	{
		CurrentPowerPoints = PowerPoints;
	}
}