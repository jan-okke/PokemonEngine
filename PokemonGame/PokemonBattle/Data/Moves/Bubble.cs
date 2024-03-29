using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Bubble : Move
{
	public override string Name => "Bubble";
	public override string Description => "A spray of countless bubbles is jetted at the opposing team. It may also lower the targets' Speed stats.";
	public override int BasePower => 40;
	public override int PowerPoints => 30;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 10;
	public override MoveTarget Target => MoveTarget.AllNearFoes;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Water;
	public override bool IgnoresProtect => false;
	public Bubble()
	{
		CurrentPowerPoints = PowerPoints;
	}
}