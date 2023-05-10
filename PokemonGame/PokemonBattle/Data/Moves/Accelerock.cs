using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Accelerock : Move
{
	public override string Name => "Accelerock";
	public override string Description => "The user smashes into the target at high speed. This move always goes first.";
	public override int BasePower => 40;
	public override int PowerPoints => 20;
	public override int Priority => 1;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Rock;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Accelerock()
	{
		CurrentPowerPoints = PowerPoints;
	}
}