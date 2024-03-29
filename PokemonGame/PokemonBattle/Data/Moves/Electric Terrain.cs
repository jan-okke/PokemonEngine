using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Electricterrain : Move
{
	public override string Name => "Electric Terrain";
	public override string Description => "The user electrifies the ground for five turns. Pokémon on the ground no longer fall asleep.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.BothSides;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Electric;
	public Electricterrain()
	{
		CurrentPowerPoints = PowerPoints;
	}
}