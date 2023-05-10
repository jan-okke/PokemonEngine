using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Leechseed : Move
{
	public override string Name => "Leech Seed";
	public override string Description => "A seed is planted on the target. It steals some HP from the target every turn.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Grass;
	public override bool IgnoresProtect => false;
	public Leechseed()
	{
		CurrentPowerPoints = PowerPoints;
	}
}