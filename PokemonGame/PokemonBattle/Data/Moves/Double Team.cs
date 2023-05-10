using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Doubleteam : Move
{
	public override string Name => "Double Team";
	public override string Description => "By moving rapidly, the user makes illusory copies of itself to raise its evasiveness.";
	public override int BasePower => 0;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public Doubleteam()
	{
		CurrentPowerPoints = PowerPoints;
	}
}