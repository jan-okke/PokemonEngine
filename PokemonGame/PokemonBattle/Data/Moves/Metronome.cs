using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Metronome : Move
{
	public override string Name => "Metronome";
	public override string Description => "The user waggles a finger and stimulates its brain into randomly using nearly any move.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public Metronome()
	{
		CurrentPowerPoints = PowerPoints;
	}
}