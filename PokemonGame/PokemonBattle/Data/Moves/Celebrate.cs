using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Celebrate : Move
{
	public override string Name => "Celebrate";
	public override string Description => "The Pokémon congratulates you on your special day!";
	public override int BasePower => 0;
	public override int PowerPoints => 40;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public Celebrate()
	{
		CurrentPowerPoints = PowerPoints;
	}
}