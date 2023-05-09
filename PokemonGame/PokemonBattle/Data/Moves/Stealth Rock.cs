using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Stealthrock : Move
{
	public override string Name => "Stealth Rock";
	public override string Description => "The user lays a trap of levitating stones around the foe. The trap hurts foes that switch into battle.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.FoeSide;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Rock;
	public Stealthrock()
	{
		CurrentPowerPoints = PowerPoints;
	}
}