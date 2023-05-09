using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Junglehealing : Move
{
	public override string Name => "Jungle Healing";
	public override string Description => "The user becomes one with the jungle, and restores HP and cures status conditions of itself and allies.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.UserAndAllies;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Grass;
	public override bool CanMetronome => false;
	public Junglehealing()
	{
		CurrentPowerPoints = PowerPoints;
	}
}