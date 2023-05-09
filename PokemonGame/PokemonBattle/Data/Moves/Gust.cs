using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Gust : Move
{
	public override string Name => "Gust";
	public override string Description => "A gust of wind is whipped up by wings and launched at the target to inflict damage.";
	public override int BasePower => 40;
	public override int PowerPoints => 35;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.Other;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Flying;
	public override bool IgnoresProtect => false;
	public Gust()
	{
		CurrentPowerPoints = PowerPoints;
	}
}