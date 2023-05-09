using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Flashcannon : Move
{
	public override string Name => "Flash Cannon";
	public override string Description => "The user gathers all its light energy and releases it at once. It may also lower the target's Sp. Def stat.";
	public override int BasePower => 80;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 10;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Steel;
	public override bool IgnoresProtect => false;
	public Flashcannon()
	{
		CurrentPowerPoints = PowerPoints;
	}
}