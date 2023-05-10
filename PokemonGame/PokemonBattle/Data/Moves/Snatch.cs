using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Snatch : Move
{
	public override string Name => "Snatch";
	public override string Description => "The user steals the effects of any healing or stat-changing move the foe attempts to use.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 4;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Dark;
	public Snatch()
	{
		CurrentPowerPoints = PowerPoints;
	}
}