using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Strugglebug : Move
{
	public override string Name => "Struggle Bug";
	public override string Description => "While resisting, the user attacks the opposing Pokémon. The targets' Sp. Atk stat is reduced.";
	public override int BasePower => 50;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 100;
	public override MoveTarget Target => MoveTarget.AllNearFoes;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Bug;
	public override bool IgnoresProtect => false;
	public Strugglebug()
	{
		CurrentPowerPoints = PowerPoints;
	}
}