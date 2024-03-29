using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Clamp : Move
{
	public override string Name => "Clamp";
	public override string Description => "The target is clamped and squeezed by the user's very thick and sturdy shell for four to five turns.";
	public override int BasePower => 35;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 85;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Water;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Clamp()
	{
		CurrentPowerPoints = PowerPoints;
	}
}