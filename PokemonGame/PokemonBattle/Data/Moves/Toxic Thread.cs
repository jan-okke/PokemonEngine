using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Toxicthread : Move
{
	public override string Name => "Toxic Thread";
	public override string Description => "The user shoots poisonous threads to poison the target and lower the target's Speed stat.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Poison;
	public override bool IgnoresProtect => false;
	public Toxicthread()
	{
		CurrentPowerPoints = PowerPoints;
	}
}