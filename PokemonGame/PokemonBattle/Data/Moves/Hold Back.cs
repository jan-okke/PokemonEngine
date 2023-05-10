using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Holdback : Move
{
	public override string Name => "Hold Back";
	public override string Description => "The user holds back when it attacks, and the target is left with at least 1 HP.";
	public override int BasePower => 40;
	public override int PowerPoints => 40;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Holdback()
	{
		CurrentPowerPoints = PowerPoints;
	}
}