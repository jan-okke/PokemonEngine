using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Coil : Move
{
	public override string Name => "Coil";
	public override string Description => "The user coils up and concentrates. This raises its Attack and Defense stats as well as its accuracy.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Poison;
	public Coil()
	{
		CurrentPowerPoints = PowerPoints;
	}
}