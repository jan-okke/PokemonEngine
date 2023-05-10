using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Darkpulse : Move
{
	public override string Name => "Dark Pulse";
	public override string Description => "The user releases a horrible aura imbued with dark thoughts. It may also make the target flinch.";
	public override int BasePower => 80;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 20;
	public override MoveTarget Target => MoveTarget.Other;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Dark;
	public override bool IgnoresProtect => false;
	public override bool IsPulseMove => true;
	public Darkpulse()
	{
		CurrentPowerPoints = PowerPoints;
	}
}