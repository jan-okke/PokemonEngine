using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Nightslash : Move
{
	public override string Name => "Night Slash";
	public override string Description => "The user slashes the target the instant an opportunity arises. Critical hits land more easily.";
	public override int BasePower => 70;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Dark;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool HasHighCriticalHitRate => true;
	public Nightslash()
	{
		CurrentPowerPoints = PowerPoints;
	}
}