using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Paraboliccharge : Move
{
	public override string Name => "Parabolic Charge";
	public override string Description => "The user attacks everything around it. The user's HP is restored by half the damage dealt.";
	public override int BasePower => 65;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.AllNearOthers;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Electric;
	public override bool IgnoresProtect => false;
	public Paraboliccharge()
	{
		CurrentPowerPoints = PowerPoints;
	}
}