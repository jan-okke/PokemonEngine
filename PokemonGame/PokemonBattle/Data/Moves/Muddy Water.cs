using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Muddywater : Move
{
	public override string Name => "Muddy Water";
	public override string Description => "The user attacks by shooting muddy water at the opposing team. It may also lower the target's accuracy.";
	public override int BasePower => 90;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 85;
	public override int EffectChance => 30;
	public override MoveTarget Target => MoveTarget.AllNearFoes;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Water;
	public override bool IgnoresProtect => false;
	public Muddywater()
	{
		CurrentPowerPoints = PowerPoints;
	}
}