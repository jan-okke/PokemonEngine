using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Naturesmadness : Move
{
	public override string Name => "Nature's Madness";
	public override string Description => "The user hits the target with the force of nature. It halves the target's HP.";
	public override int BasePower => 1;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Fairy;
	public override bool IgnoresProtect => false;
	public override bool CanMetronome => false;
	public Naturesmadness()
	{
		CurrentPowerPoints = PowerPoints;
	}
}