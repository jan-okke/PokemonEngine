using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Teatime : Move
{
	public override string Name => "Teatime";
	public override string Description => "The user has teatime with all the Pokémon in the battle. Each Pokémon eats its held Berry.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.AllBattlers;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public Teatime()
	{
		CurrentPowerPoints = PowerPoints;
	}
}