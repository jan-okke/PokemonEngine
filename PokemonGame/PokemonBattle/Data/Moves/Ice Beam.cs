using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Icebeam : Move
{
	public override string Name => "Ice Beam";
	public override string Description => "The target is struck with an icy-cold beam of energy. It may also freeze the target solid.";
	public override int BasePower => 90;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 10;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Ice;
	public override bool IgnoresProtect => false;
	public Icebeam()
	{
		CurrentPowerPoints = PowerPoints;
	}
}