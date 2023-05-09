using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Sketch : Move
{
	public override string Name => "Sketch";
	public override string Description => "It enables the user to permanently learn the move last used by the foe. Once used, Sketch disappears.";
	public override int BasePower => 0;
	public override int PowerPoints => 1;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public Sketch()
	{
		CurrentPowerPoints = PowerPoints;
	}
}