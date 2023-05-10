using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Coaching : Move
{
	public override string Name => "Coaching";
	public override string Description => "The user properly coaches its ally Pokémon, boosting their Attack and Defense stats.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.AllAllies;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Fighting;
	public Coaching()
	{
		CurrentPowerPoints = PowerPoints;
	}
}