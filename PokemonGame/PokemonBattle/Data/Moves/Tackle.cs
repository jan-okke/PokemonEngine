using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Tackle : Move
{
	public override string Name => "Tackle";
	public override string Description => "A physical attack in which the user charges and slams into the target with its whole body.";
	public override int BasePower => 40;
	public override int PowerPoints => 35;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Tackle()
	{
		CurrentPowerPoints = PowerPoints;
	}
}