using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Spikecannon : Move
{
	public override string Name => "Spike Cannon";
	public override string Description => "Sharp spikes are shot at the target in rapid succession. They hit two to five times in a row.";
	public override int BasePower => 20;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public Spikecannon()
	{
		CurrentPowerPoints = PowerPoints;
	}
}