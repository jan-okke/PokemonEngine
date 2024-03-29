using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Signalbeam : Move
{
	public override string Name => "Signal Beam";
	public override string Description => "The user attacks with a sinister beam of light. It may also confuse the target.";
	public override int BasePower => 75;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 10;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Bug;
	public override bool IgnoresProtect => false;
	public Signalbeam()
	{
		CurrentPowerPoints = PowerPoints;
	}
}