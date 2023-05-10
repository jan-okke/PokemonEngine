using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Sunnyday : Move
{
	public override string Name => "Sunny Day";
	public override string Description => "The user intensifies the sun for five turns, powering up Fire-type moves.";
	public override int BasePower => 0;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.BothSides;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Fire;
	public Sunnyday()
	{
		CurrentPowerPoints = PowerPoints;
	}
}