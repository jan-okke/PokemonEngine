using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Dynamaxcannon : Move
{
	public override string Name => "Dynamax Cannon";
	public override string Description => "The user unleashes a strong beam from its core.";
	public override int BasePower => 100;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Dragon;
	public override bool IgnoresProtect => false;
	public override bool CanMetronome => false;
	public Dynamaxcannon()
	{
		CurrentPowerPoints = PowerPoints;
	}
}