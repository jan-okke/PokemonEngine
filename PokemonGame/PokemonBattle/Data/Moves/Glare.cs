using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Glare : Move
{
	public override string Name => "Glare";
	public override string Description => "The user intimidates the target with the pattern on its belly to cause paralysis.";
	public override int BasePower => 0;
	public override int PowerPoints => 30;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public Glare()
	{
		CurrentPowerPoints = PowerPoints;
	}
}