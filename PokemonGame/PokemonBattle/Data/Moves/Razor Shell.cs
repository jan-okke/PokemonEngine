using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Razorshell : Move
{
	public override string Name => "Razor Shell";
	public override string Description => "The user cuts the foe with sharp shells. It may also lower the target's Defense stat.";
	public override int BasePower => 75;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 95;
	public override int EffectChance => 50;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Water;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Razorshell()
	{
		CurrentPowerPoints = PowerPoints;
	}
}