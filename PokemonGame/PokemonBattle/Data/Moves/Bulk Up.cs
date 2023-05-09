using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Bulkup : Move
{
	public override string Name => "Bulk Up";
	public override string Description => "The user tenses its muscles to bulk up its body, boosting both its Attack and Defense stats.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Fighting;
	public Bulkup()
	{
		CurrentPowerPoints = PowerPoints;
	}
}