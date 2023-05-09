using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Wonderroom : Move
{
	public override string Name => "Wonder Room";
	public override string Description => "The user creates a bizarre area in which Pokémon's Defense and Sp. Def stats are swapped for 5 turns.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => -7;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.BothSides;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Psychic;
	public Wonderroom()
	{
		CurrentPowerPoints = PowerPoints;
	}
}