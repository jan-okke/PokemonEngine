using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Shadowclaw : Move
{
	public override string Name => "Shadow Claw";
	public override string Description => "The user slashes with a sharp claw made from shadows. Critical hits land more easily.";
	public override int BasePower => 70;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Ghost;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool HasHighCriticalHitRate => true;
	public Shadowclaw()
	{
		CurrentPowerPoints = PowerPoints;
	}
}