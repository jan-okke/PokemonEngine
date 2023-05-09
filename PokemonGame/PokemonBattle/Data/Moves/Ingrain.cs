using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Ingrain : Move
{
	public override string Name => "Ingrain";
	public override string Description => "The user lays roots that restore its HP on every turn. Because it is rooted, it can't switch out.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Grass;
	public Ingrain()
	{
		CurrentPowerPoints = PowerPoints;
	}
}