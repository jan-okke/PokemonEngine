using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Doomdesire : Move
{
	public override string Name => "Doom Desire";
	public override string Description => "Two turns after this move is used, the user blasts the target with a concentrated bundle of light.";
	public override int BasePower => 140;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Steel;
	public Doomdesire()
	{
		CurrentPowerPoints = PowerPoints;
	}
}