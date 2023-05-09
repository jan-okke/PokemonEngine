using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Disarmingvoice : Move
{
	public override string Name => "Disarming Voice";
	public override string Description => "Letting out a charming cry, the user does emotional damage to foes. This attack never misses.";
	public override int BasePower => 40;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.AllNearFoes;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Fairy;
	public override bool IgnoresProtect => false;
	public override bool IsSoundMove => true;
	public Disarmingvoice()
	{
		CurrentPowerPoints = PowerPoints;
	}
}