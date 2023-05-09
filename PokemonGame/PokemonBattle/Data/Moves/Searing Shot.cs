using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Searingshot : Move
{
	public override string Name => "Searing Shot";
	public override string Description => "An inferno of scarlet flames torches everything around the user. It may leave the foe with a burn.";
	public override int BasePower => 100;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 30;
	public override MoveTarget Target => MoveTarget.AllNearOthers;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Fire;
	public override bool IgnoresProtect => false;
	public override bool IsBombMove => true;
	public Searingshot()
	{
		CurrentPowerPoints = PowerPoints;
	}
}