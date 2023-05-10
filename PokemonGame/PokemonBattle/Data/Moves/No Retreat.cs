using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Noretreat : Move
{
	public override string Name => "No Retreat";
	public override string Description => "This move raises all the user's stats but prevents the user from switching out or fleeing.";
	public override int BasePower => 0;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Fighting;
	public Noretreat()
	{
		CurrentPowerPoints = PowerPoints;
	}
}