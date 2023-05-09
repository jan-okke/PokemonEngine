using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Finalgambit : Move
{
	public override string Name => "Final Gambit";
	public override string Description => "The user risks all to attack the foe. The user faints but does damage equal to its HP.";
	public override int BasePower => 1;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Fighting;
	public override bool IgnoresProtect => false;
	public Finalgambit()
	{
		CurrentPowerPoints = PowerPoints;
	}
}