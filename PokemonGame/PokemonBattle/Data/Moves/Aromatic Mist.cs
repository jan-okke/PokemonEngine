using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Aromaticmist : Move
{
	public override string Name => "Aromatic Mist";
	public override string Description => "The user raises the Sp. Def stat of an ally Pokémon by using a mysterious aroma.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearAlly;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Fairy;
	public Aromaticmist()
	{
		CurrentPowerPoints = PowerPoints;
	}
}