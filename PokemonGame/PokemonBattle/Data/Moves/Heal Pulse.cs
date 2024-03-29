using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Healpulse : Move
{
	public override string Name => "Heal Pulse";
	public override string Description => "The user emits a healing pulse which restores the target's HP by up to half of its max HP.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.Other;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Psychic;
	public override bool IgnoresProtect => false;
	public override bool IsPulseMove => true;
	public Healpulse()
	{
		CurrentPowerPoints = PowerPoints;
	}
}