using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Thunderouskick : Move
{
	public override string Name => "Thunderous Kick";
	public override string Description => "Overwhelms the target with lightning-like movement, then kicks. Lowers the target's Defense stat.";
	public override int BasePower => 90;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 100;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Fighting;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool CanMetronome => false;
	public Thunderouskick()
	{
		CurrentPowerPoints = PowerPoints;
	}
}