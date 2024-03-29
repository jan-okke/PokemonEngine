using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Psychicterrain : Move
{
	public override string Name => "Psychic Terrain";
	public override string Description => "Protects grounded Pokémon from priority moves and powers up Psychic-type moves for five turns.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.BothSides;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Psychic;
	public Psychicterrain()
	{
		CurrentPowerPoints = PowerPoints;
	}
}