using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Sweetscent : Move
{
	public override string Name => "Sweet Scent";
	public override string Description => "A sweet scent that lowers the foe's evasiveness. It also lures wild Pokémon if used in grass, etc.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.AllNearFoes;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public Sweetscent()
	{
		CurrentPowerPoints = PowerPoints;
	}
}