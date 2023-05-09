using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Allyswitch : Move
{
	public override string Name => "Ally Switch";
	public override string Description => "The user teleports using a strange power and switches its place with one of its allies.";
	public override int BasePower => 0;
	public override int PowerPoints => 15;
	public override int Priority => 2;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Psychic;
	public Allyswitch()
	{
		CurrentPowerPoints = PowerPoints;
	}
}