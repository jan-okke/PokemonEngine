using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Explosion : Move
{
	public override string Name => "Explosion";
	public override string Description => "The user explodes to inflict damage on those around it. The user faints upon using this move.";
	public override int BasePower => 250;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.AllNearOthers;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public Explosion()
	{
		CurrentPowerPoints = PowerPoints;
	}
}