using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Lick : Move
{
	public override string Name => "Lick";
	public override string Description => "The target is licked with a long tongue, causing damage. It may also leave the target with paralysis.";
	public override int BasePower => 30;
	public override int PowerPoints => 30;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 30;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Ghost;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Lick()
	{
		CurrentPowerPoints = PowerPoints;
	}
}