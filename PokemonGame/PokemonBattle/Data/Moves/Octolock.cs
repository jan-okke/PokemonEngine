using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Octolock : Move
{
	public override string Name => "Octolock";
	public override string Description => "Locks the target in and prevents it from fleeing. Also lowers the target's Defense and Sp. Def each turn.";
	public override int BasePower => 0;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Fighting;
	public override bool IgnoresProtect => false;
	public Octolock()
	{
		CurrentPowerPoints = PowerPoints;
	}
}