using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Iondeluge : Move
{
	public override string Name => "Ion Deluge";
	public override string Description => "The user disperses electrically charged particles. Normal-type moves become Electric-type.";
	public override int BasePower => 0;
	public override int PowerPoints => 25;
	public override int Priority => 1;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.BothSides;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Electric;
	public Iondeluge()
	{
		CurrentPowerPoints = PowerPoints;
	}
}