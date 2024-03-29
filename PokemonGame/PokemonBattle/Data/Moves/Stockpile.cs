using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Stockpile : Move
{
	public override string Name => "Stockpile";
	public override string Description => "The user charges up power and raises both its Defense and Sp. Def. The move can be used three times.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public Stockpile()
	{
		CurrentPowerPoints = PowerPoints;
	}
}