using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Psybeam : Move
{
	public override string Name => "Psybeam";
	public override string Description => "The target is attacked with a peculiar ray. It may also cause confusion.";
	public override int BasePower => 65;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 10;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Psychic;
	public override bool IgnoresProtect => false;
	public Psybeam()
	{
		CurrentPowerPoints = PowerPoints;
	}
}