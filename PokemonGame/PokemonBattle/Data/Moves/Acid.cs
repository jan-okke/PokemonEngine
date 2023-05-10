using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Acid : Move
{
	public override string Name => "Acid";
	public override string Description => "The foe is attacked with a spray of harsh acid. It may also lower the target's Sp. Def stat.";
	public override int BasePower => 40;
	public override int PowerPoints => 30;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 10;
	public override MoveTarget Target => MoveTarget.AllNearFoes;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Poison;
	public override bool IgnoresProtect => false;
	public Acid()
	{
		CurrentPowerPoints = PowerPoints;
	}
}