using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Magiccoat : Move
{
	public override string Name => "Magic Coat";
	public override string Description => "A barrier reflects back to the target moves like Leech Seed and moves that damage status.";
	public override int BasePower => 0;
	public override int PowerPoints => 15;
	public override int Priority => 4;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Psychic;
	public Magiccoat()
	{
		CurrentPowerPoints = PowerPoints;
	}
}