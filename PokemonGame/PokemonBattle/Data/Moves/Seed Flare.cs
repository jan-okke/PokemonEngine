using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Seedflare : Move
{
	public override string Name => "Seed Flare";
	public override string Description => "The user generates a shock wave from within its body. It may harshly lower the target's Sp. Def.";
	public override int BasePower => 120;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 85;
	public override int EffectChance => 40;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Grass;
	public override bool IgnoresProtect => false;
	public Seedflare()
	{
		CurrentPowerPoints = PowerPoints;
	}
}