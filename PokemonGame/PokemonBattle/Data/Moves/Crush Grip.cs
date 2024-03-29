using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Crushgrip : Move
{
	public override string Name => "Crush Grip";
	public override string Description => "The target is crushed with great force. The attack is more powerful the more HP the target has left.";
	public override int BasePower => 1;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Crushgrip()
	{
		CurrentPowerPoints = PowerPoints;
	}
}