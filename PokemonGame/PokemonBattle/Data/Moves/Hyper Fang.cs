using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Hyperfang : Move
{
	public override string Name => "Hyper Fang";
	public override string Description => "The user bites hard on the target with its sharp front fangs. It may also make the target flinch.";
	public override int BasePower => 80;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 10;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool IsBitingMove => true;
	public Hyperfang()
	{
		CurrentPowerPoints = PowerPoints;
	}
}