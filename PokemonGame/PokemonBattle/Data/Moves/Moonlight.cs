using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Moonlight : Move
{
	public override string Name => "Moonlight";
	public override string Description => "The user restores its own HP. The amount of HP regained varies with the weather.";
	public override int BasePower => 0;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Fairy;
	public Moonlight()
	{
		CurrentPowerPoints = PowerPoints;
	}
}