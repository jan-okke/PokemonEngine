using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Howl : Move
{
	public override string Name => "Howl";
	public override string Description => "The user howls loudly to raise the spirit of itself and allies, boosting their Attack stats.";
	public override int BasePower => 0;
	public override int PowerPoints => 40;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.UserAndAllies;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsSoundMove => true;
	public Howl()
	{
		CurrentPowerPoints = PowerPoints;
	}
}