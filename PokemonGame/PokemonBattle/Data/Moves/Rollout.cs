using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Rollout : Move
{
	public override string Name => "Rollout";
	public override string Description => "The user continually rolls into the target over five turns. It becomes stronger each time it hits.";
	public override int BasePower => 30;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Rock;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Rollout()
	{
		CurrentPowerPoints = PowerPoints;
	}
}