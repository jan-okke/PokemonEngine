using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Metalburst : Move
{
	public override string Name => "Metal Burst";
	public override string Description => "The user retaliates with much greater power against the target that last inflicted damage on it.";
	public override int BasePower => 1;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.None;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Steel;
	public override bool IgnoresProtect => false;
	public Metalburst()
	{
		CurrentPowerPoints = PowerPoints;
	}
}