using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Iceshard : Move
{
	public override string Name => "Ice Shard";
	public override string Description => "The user flash freezes chunks of ice and hurls them at the target. This move always goes first.";
	public override int BasePower => 40;
	public override int PowerPoints => 30;
	public override int Priority => 1;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Ice;
	public override bool IgnoresProtect => false;
	public Iceshard()
	{
		CurrentPowerPoints = PowerPoints;
	}
}