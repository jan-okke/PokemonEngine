using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Megahorn : Move
{
	public override string Name => "Megahorn";
	public override string Description => "Using its tough and impressive horn, the user rams into the target with no letup.";
	public override int BasePower => 120;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 85;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Bug;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Megahorn()
	{
		CurrentPowerPoints = PowerPoints;
	}
}