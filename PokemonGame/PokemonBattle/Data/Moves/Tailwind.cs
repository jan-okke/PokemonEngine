using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Tailwind : Move
{
	public override string Name => "Tailwind";
	public override string Description => "The user whips up a turbulent whirlwind that ups the Speed of all party Pokémon for four turns.";
	public override int BasePower => 0;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.UserSide;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Flying;
	public Tailwind()
	{
		CurrentPowerPoints = PowerPoints;
	}
}