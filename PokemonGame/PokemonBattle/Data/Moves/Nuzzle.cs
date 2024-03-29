using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Nuzzle : Move
{
	public override string Name => "Nuzzle";
	public override string Description => "The user nuzzles its electrified cheeks against the target. This also leaves the target with paralysis.";
	public override int BasePower => 20;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 100;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Electric;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Nuzzle()
	{
		CurrentPowerPoints = PowerPoints;
	}
}