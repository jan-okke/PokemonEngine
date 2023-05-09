using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Smog : Move
{
	public override string Name => "Smog";
	public override string Description => "The target is attacked with a discharge of filthy gases. It may also poison the target.";
	public override int BasePower => 30;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 70;
	public override int EffectChance => 40;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Poison;
	public override bool IgnoresProtect => false;
	public Smog()
	{
		CurrentPowerPoints = PowerPoints;
	}
}