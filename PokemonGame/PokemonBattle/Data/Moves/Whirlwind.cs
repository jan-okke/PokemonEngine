using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Whirlwind : Move
{
	public override string Name => "Whirlwind";
	public override string Description => "The foe is blown away, to be replaced by another Pokémon in its party. In the wild, the battle ends.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => -6;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public Whirlwind()
	{
		CurrentPowerPoints = PowerPoints;
	}
}