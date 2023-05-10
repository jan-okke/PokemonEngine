using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Hyperspacefury : Move
{
	public override string Name => "Hyperspace Fury";
	public override string Description => "Unleashes a barrage of multi-arm attacks, skipping protections. The user's Defense stat falls.";
	public override int BasePower => 100;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Dark;
	public override bool CanMetronome => false;
	public Hyperspacefury()
	{
		CurrentPowerPoints = PowerPoints;
	}
}