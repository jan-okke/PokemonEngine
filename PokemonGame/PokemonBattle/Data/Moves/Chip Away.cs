using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Chipaway : Move
{
	public override string Name => "Chip Away";
	public override string Description => "Seeking an opening, the user strikes continually. The foe's stat changes don't affect the damage.";
	public override int BasePower => 70;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Chipaway()
	{
		CurrentPowerPoints = PowerPoints;
	}
}