using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Bubblebeam : Move
{
	public override string Name => "Bubble Beam";
	public override string Description => "A spray of bubbles is forcefully ejected at the target. It may also lower its Speed stat.";
	public override int BasePower => 65;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 10;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Water;
	public override bool IgnoresProtect => false;
	public Bubblebeam()
	{
		CurrentPowerPoints = PowerPoints;
	}
}