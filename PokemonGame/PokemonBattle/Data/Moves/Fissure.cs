using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Fissure : Move
{
	public override string Name => "Fissure";
	public override string Description => "The user opens up a fissure in the ground and drops the foe in. The target instantly faints if it hits.";
	public override int BasePower => 1;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 30;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Ground;
	public override bool IgnoresProtect => false;
	public Fissure()
	{
		CurrentPowerPoints = PowerPoints;
	}
}