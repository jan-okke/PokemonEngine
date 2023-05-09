using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Mistyterrain : Move
{
	public override string Name => "Misty Terrain";
	public override string Description => "The user covers the ground with mist for five turns. Grounded Pokémon can't gain status conditions.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.BothSides;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Fairy;
	public Mistyterrain()
	{
		CurrentPowerPoints = PowerPoints;
	}
}