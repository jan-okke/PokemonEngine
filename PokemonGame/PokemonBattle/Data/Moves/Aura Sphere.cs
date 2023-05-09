using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Aurasphere : Move
{
	public override string Name => "Aura Sphere";
	public override string Description => "The user looses a blast of aura power from deep within its body. This move is certain to hit.";
	public override int BasePower => 80;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.Other;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Fighting;
	public override bool IgnoresProtect => false;
	public override bool IsPulseMove => true;
	public override bool IsBombMove => true;
	public Aurasphere()
	{
		CurrentPowerPoints = PowerPoints;
	}
}