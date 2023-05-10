using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Thundercage : Move
{
	public override string Name => "Thunder Cage";
	public override string Description => "The user traps the target in a cage of sparking electricity for four to five turns.";
	public override int BasePower => 80;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Electric;
	public override bool IgnoresProtect => false;
	public override bool CanMetronome => false;
	public Thundercage()
	{
		CurrentPowerPoints = PowerPoints;
	}
}