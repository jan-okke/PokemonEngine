using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Synchronoise : Move
{
	public override string Name => "Synchronoise";
	public override string Description => "Using an odd shock wave, the user damages any Pokémon of the same type as the user.";
	public override int BasePower => 120;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.AllNearOthers;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Psychic;
	public override bool IgnoresProtect => false;
	public Synchronoise()
	{
		CurrentPowerPoints = PowerPoints;
	}
}