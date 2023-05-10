using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Slam : Move
{
	public override string Name => "Slam";
	public override string Description => "The target is slammed with a long tail, vines, etc., to inflict damage.";
	public override int BasePower => 80;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 75;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Slam()
	{
		CurrentPowerPoints = PowerPoints;
	}
}