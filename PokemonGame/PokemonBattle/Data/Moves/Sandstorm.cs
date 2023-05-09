using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Sandstorm : Move
{
	public override string Name => "Sandstorm";
	public override string Description => "Summons a five-turn sandstorm to hurt all combatants except the Rock, Ground, and Steel types.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.BothSides;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Rock;
	public Sandstorm()
	{
		CurrentPowerPoints = PowerPoints;
	}
}