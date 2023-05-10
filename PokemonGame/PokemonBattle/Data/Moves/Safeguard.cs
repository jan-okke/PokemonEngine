using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Safeguard : Move
{
	public override string Name => "Safeguard";
	public override string Description => "The user creates a protective field that prevents status problems for five turns.";
	public override int BasePower => 0;
	public override int PowerPoints => 25;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.UserSide;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public Safeguard()
	{
		CurrentPowerPoints = PowerPoints;
	}
}