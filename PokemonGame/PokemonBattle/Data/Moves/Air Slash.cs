using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Airslash : Move
{
	public override string Name => "Air Slash";
	public override string Description => "The user attacks with a blade of air that slices even the sky. It may also make the target flinch.";
	public override int BasePower => 75;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 95;
	public override int EffectChance => 30;
	public override MoveTarget Target => MoveTarget.Other;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Flying;
	public override bool IgnoresProtect => false;
	public Airslash()
	{
		CurrentPowerPoints = PowerPoints;
	}
}