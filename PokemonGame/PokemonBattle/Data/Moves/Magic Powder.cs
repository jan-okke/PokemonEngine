using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Magicpowder : Move
{
	public override string Name => "Magic Powder";
	public override string Description => "The user scatters a cloud of magic powder that changes the target to Psychic type.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Psychic;
	public override bool IgnoresProtect => false;
	public override bool IsPowderMove => true;
	public Magicpowder()
	{
		CurrentPowerPoints = PowerPoints;
	}
}