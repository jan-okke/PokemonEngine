using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Helpinghand : Move
{
	public override string Name => "Helping Hand";
	public override string Description => "The user assists an ally by boosting the power of its attack.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 5;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearAlly;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public Helpinghand()
	{
		CurrentPowerPoints = PowerPoints;
	}
}