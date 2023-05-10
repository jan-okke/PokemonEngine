using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Spikes : Move
{
	public override string Name => "Spikes";
	public override string Description => "The user lays a trap of spikes at the foe's feet. The trap hurts foes that switch into battle.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.FoeSide;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Ground;
	public Spikes()
	{
		CurrentPowerPoints = PowerPoints;
	}
}