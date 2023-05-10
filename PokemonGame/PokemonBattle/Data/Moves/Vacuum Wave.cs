using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Vacuumwave : Move
{
	public override string Name => "Vacuum Wave";
	public override string Description => "The user whirls its fists to send a wave of pure vacuum at the target. This move always goes first.";
	public override int BasePower => 40;
	public override int PowerPoints => 30;
	public override int Priority => 1;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Fighting;
	public override bool IgnoresProtect => false;
	public Vacuumwave()
	{
		CurrentPowerPoints = PowerPoints;
	}
}