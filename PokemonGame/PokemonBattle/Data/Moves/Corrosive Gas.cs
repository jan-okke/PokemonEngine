using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Corrosivegas : Move
{
	public override string Name => "Corrosive Gas";
	public override string Description => "The user surrounds everything around it with highly acidic gas and melts away items they hold.";
	public override int BasePower => 0;
	public override int PowerPoints => 40;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.AllNearOthers;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Poison;
	public override bool IgnoresProtect => false;
	public Corrosivegas()
	{
		CurrentPowerPoints = PowerPoints;
	}
}