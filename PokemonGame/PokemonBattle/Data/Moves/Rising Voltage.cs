using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Risingvoltage : Move
{
	public override string Name => "Rising Voltage";
	public override string Description => "The user attacks with electric voltage rising from the ground. Power is doubled on Electric Terrain.";
	public override int BasePower => 70;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Electric;
	public override bool IgnoresProtect => false;
	public Risingvoltage()
	{
		CurrentPowerPoints = PowerPoints;
	}
}