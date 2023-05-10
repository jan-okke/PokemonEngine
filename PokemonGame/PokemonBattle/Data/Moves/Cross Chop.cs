using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Crosschop : Move
{
	public override string Name => "Cross Chop";
	public override string Description => "The user delivers a double chop with its forearms crossed. Critical hits land more easily.";
	public override int BasePower => 100;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 80;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Fighting;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool HasHighCriticalHitRate => true;
	public Crosschop()
	{
		CurrentPowerPoints = PowerPoints;
	}
}