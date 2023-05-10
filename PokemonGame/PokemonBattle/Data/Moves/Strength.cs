using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Strength : Move
{
	public override string Name => "Strength";
	public override string Description => "The target is slugged with a punch thrown at maximum power. It can also be used to move heavy boulders.";
	public override int BasePower => 80;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Strength()
	{
		CurrentPowerPoints = PowerPoints;
	}
}