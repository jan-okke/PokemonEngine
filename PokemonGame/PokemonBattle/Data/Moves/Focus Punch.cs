using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Focuspunch : Move
{
	public override string Name => "Focus Punch";
	public override string Description => "The user focuses its mind before launching a punch. It will fail if the user is hit before it is used.";
	public override int BasePower => 150;
	public override int PowerPoints => 20;
	public override int Priority => -3;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Fighting;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool IsPunchingMove => true;
	public Focuspunch()
	{
		CurrentPowerPoints = PowerPoints;
	}
}