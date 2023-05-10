using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Drainingkiss : Move
{
	public override string Name => "Draining Kiss";
	public override string Description => "The user steals the target's HP with a kiss. The user's HP is restored by over half of the damage dealt.";
	public override int BasePower => 50;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Fairy;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Drainingkiss()
	{
		CurrentPowerPoints = PowerPoints;
	}
}