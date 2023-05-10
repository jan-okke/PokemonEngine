using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Decorate : Move
{
	public override string Name => "Decorate";
	public override string Description => "The user sharply raises the target's Attack and Sp. Atk stats by decorating the target.";
	public override int BasePower => 0;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Fairy;
	public override bool CanMetronome => false;
	public Decorate()
	{
		CurrentPowerPoints = PowerPoints;
	}
}