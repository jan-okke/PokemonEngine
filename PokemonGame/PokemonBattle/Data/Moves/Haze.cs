using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Haze : Move
{
	public override string Name => "Haze";
	public override string Description => "The user creates a haze that eliminates every stat change among all the Pokémon engaged in battle.";
	public override int BasePower => 0;
	public override int PowerPoints => 30;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.BothSides;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Ice;
	public Haze()
	{
		CurrentPowerPoints = PowerPoints;
	}
}