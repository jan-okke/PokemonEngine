using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Hiddenpower : Move
{
	public override string Name => "Hidden Power";
	public override string Description => "A unique attack that varies in type and intensity depending on the Pokémon using it.";
	public override int BasePower => 60;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public Hiddenpower()
	{
		CurrentPowerPoints = PowerPoints;
	}
}