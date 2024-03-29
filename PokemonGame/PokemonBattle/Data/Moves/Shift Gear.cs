using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Shiftgear : Move
{
	public override string Name => "Shift Gear";
	public override string Description => "The user rotates its gears, raising its Attack and sharply raising its Speed.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Steel;
	public Shiftgear()
	{
		CurrentPowerPoints = PowerPoints;
	}
}