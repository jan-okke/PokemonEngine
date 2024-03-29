using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Cottonguard : Move
{
	public override string Name => "Cotton Guard";
	public override string Description => "The user protects itself by wrapping its body in soft cotton, drastically raising its Defense stat.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Grass;
	public Cottonguard()
	{
		CurrentPowerPoints = PowerPoints;
	}
}