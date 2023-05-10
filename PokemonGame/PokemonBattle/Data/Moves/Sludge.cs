using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Sludge : Move
{
	public override string Name => "Sludge";
	public override string Description => "Unsanitary sludge is hurled at the target. It may also poison the target.";
	public override int BasePower => 65;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 30;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Poison;
	public override bool IgnoresProtect => false;
	public Sludge()
	{
		CurrentPowerPoints = PowerPoints;
	}
}