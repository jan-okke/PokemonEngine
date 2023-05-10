using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Skittersmack : Move
{
	public override string Name => "Skitter Smack";
	public override string Description => "The user skitters behind the target to attack. This also lowers the target's Sp. Atk stat.";
	public override int BasePower => 70;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 100;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Bug;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Skittersmack()
	{
		CurrentPowerPoints = PowerPoints;
	}
}