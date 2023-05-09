using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Shoreup : Move
{
	public override string Name => "Shore Up";
	public override string Description => "The user regains up to half of its max HP. It restores more HP in a sandstorm.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Ground;
	public Shoreup()
	{
		CurrentPowerPoints = PowerPoints;
	}
}