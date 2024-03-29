using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Poisonjab : Move
{
	public override string Name => "Poison Jab";
	public override string Description => "The target is stabbed with a tentacle or arm seeped with poison. It may also poison the target.";
	public override int BasePower => 80;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 30;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Poison;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Poisonjab()
	{
		CurrentPowerPoints = PowerPoints;
	}
}