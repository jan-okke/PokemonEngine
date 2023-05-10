using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Partingshot : Move
{
	public override string Name => "Parting Shot";
	public override string Description => "With a parting threat, the user lowers the target's Attack and Sp. Atk stats. Then it switches out.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Dark;
	public override bool IgnoresProtect => false;
	public override bool IsSoundMove => true;
	public Partingshot()
	{
		CurrentPowerPoints = PowerPoints;
	}
}