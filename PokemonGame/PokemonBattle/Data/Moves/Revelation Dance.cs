using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Revelationdance : Move
{
	public override string Name => "Revelation Dance";
	public override string Description => "The user attacks the target by dancing very hard. The user's type determines the type of this move.";
	public override int BasePower => 90;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public override bool IsDanceMove => true;
	public Revelationdance()
	{
		CurrentPowerPoints = PowerPoints;
	}
}