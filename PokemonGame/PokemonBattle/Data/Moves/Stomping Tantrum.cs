using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Stompingtantrum : Move
{
	public override string Name => "Stomping Tantrum";
	public override string Description => "The user attacks driven by frustration. Power increases if the user's previous move failed.";
	public override int BasePower => 75;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Ground;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Stompingtantrum()
	{
		CurrentPowerPoints = PowerPoints;
	}
}