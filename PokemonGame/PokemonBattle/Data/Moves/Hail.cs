using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Hail : Move
{
	public override string Name => "Hail";
	public override string Description => "The user summons a hail storm lasting five turns. It damages all Pokémon except the Ice type.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.BothSides;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Ice;
	public Hail()
	{
		CurrentPowerPoints = PowerPoints;
	}
}