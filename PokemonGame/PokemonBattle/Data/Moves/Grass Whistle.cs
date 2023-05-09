using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Grasswhistle : Move
{
	public override string Name => "Grass Whistle";
	public override string Description => "The user plays a pleasant melody that lulls the target into a deep sleep.";
	public override int BasePower => 0;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 55;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Grass;
	public override bool IgnoresProtect => false;
	public override bool IsSoundMove => true;
	public Grasswhistle()
	{
		CurrentPowerPoints = PowerPoints;
	}
}