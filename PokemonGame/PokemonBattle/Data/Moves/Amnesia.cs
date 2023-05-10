using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Amnesia : Move
{
	public override string Name => "Amnesia";
	public override string Description => "The user temporarily empties its mind to forget its concerns. It sharply raises the user's Sp. Def stat.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Psychic;
	public Amnesia()
	{
		CurrentPowerPoints = PowerPoints;
	}
}