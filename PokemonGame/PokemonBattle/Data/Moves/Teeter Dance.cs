using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Teeterdance : Move
{
	public override string Name => "Teeter Dance";
	public override string Description => "The user performs a wobbly dance that confuses the Pokémon around it.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.AllNearOthers;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public override bool IsDanceMove => true;
	public Teeterdance()
	{
		CurrentPowerPoints = PowerPoints;
	}
}