using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Metalsound : Move
{
	public override string Name => "Metal Sound";
	public override string Description => "A horrible sound like scraping metal harshly reduces the target's Sp. Def stat.";
	public override int BasePower => 0;
	public override int PowerPoints => 40;
	public override int Priority => 0;
	public override int Accuracy => 85;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Steel;
	public override bool IgnoresProtect => false;
	public override bool IsSoundMove => true;
	public Metalsound()
	{
		CurrentPowerPoints = PowerPoints;
	}
}