using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Doubleslap : Move
{
	public override string Name => "Double Slap";
	public override string Description => "The target is slapped repeatedly, back and forth, two to five times in a row.";
	public override int BasePower => 15;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 85;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Doubleslap()
	{
		CurrentPowerPoints = PowerPoints;
	}
}