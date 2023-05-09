using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Sonicboom : Move
{
	public override string Name => "Sonic Boom";
	public override string Description => "The target is hit with a destructive shock wave that always inflicts 20 HP damage.";
	public override int BasePower => 1;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public Sonicboom()
	{
		CurrentPowerPoints = PowerPoints;
	}
}