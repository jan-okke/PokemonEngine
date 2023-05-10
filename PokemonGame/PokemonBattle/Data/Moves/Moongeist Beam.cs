using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Moongeistbeam : Move
{
	public override string Name => "Moongeist Beam";
	public override string Description => "The user emits a sinister ray. This move can be used on the target regardless of its Abilities.";
	public override int BasePower => 100;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Ghost;
	public override bool IgnoresProtect => false;
	public override bool CanMetronome => false;
	public Moongeistbeam()
	{
		CurrentPowerPoints = PowerPoints;
	}
}