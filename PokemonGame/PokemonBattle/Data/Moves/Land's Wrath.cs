using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Landswrath : Move
{
	public override string Name => "Land's Wrath";
	public override string Description => "The user gathers the energy of the land and focuses that power on foes to damage them.";
	public override int BasePower => 90;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.AllNearFoes;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Ground;
	public override bool IgnoresProtect => false;
	public Landswrath()
	{
		CurrentPowerPoints = PowerPoints;
	}
}