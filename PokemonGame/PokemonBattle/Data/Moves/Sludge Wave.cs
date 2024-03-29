using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Sludgewave : Move
{
	public override string Name => "Sludge Wave";
	public override string Description => "It swamps the area around the user with a giant sludge wave. It may also poison those hit.";
	public override int BasePower => 95;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 10;
	public override MoveTarget Target => MoveTarget.AllNearOthers;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Poison;
	public override bool IgnoresProtect => false;
	public Sludgewave()
	{
		CurrentPowerPoints = PowerPoints;
	}
}