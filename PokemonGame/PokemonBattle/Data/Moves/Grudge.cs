using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Grudge : Move
{
	public override string Name => "Grudge";
	public override string Description => "If the user faints, the user's grudge fully depletes the PP of the foe's move that knocked it out.";
	public override int BasePower => 0;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Ghost;
	public Grudge()
	{
		CurrentPowerPoints = PowerPoints;
	}
}