using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Rapidspin : Move
{
	public override string Name => "Rapid Spin";
	public override string Description => "A spin attack that raises the user's Speed and eliminates the effects of Bind, Spikes, etc.";
	public override int BasePower => 50;
	public override int PowerPoints => 40;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 100;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Rapidspin()
	{
		CurrentPowerPoints = PowerPoints;
	}
}