using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Softboiled : Move
{
	public override string Name => "Soft-Boiled";
	public override string Description => "The user restores its own HP by up to half of its maximum HP. May also be used in the field to heal HP.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public Softboiled()
	{
		CurrentPowerPoints = PowerPoints;
	}
}