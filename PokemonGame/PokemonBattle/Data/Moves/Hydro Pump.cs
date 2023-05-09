using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Hydropump : Move
{
	public override string Name => "Hydro Pump";
	public override string Description => "The target is blasted by a huge volume of water launched under great pressure.";
	public override int BasePower => 110;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 80;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Water;
	public override bool IgnoresProtect => false;
	public Hydropump()
	{
		CurrentPowerPoints = PowerPoints;
	}
}