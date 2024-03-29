using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Swordsdance : Move
{
	public override string Name => "Swords Dance";
	public override string Description => "A frenetic dance to uplift the fighting spirit. It sharply raises the user's Attack stat.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsDanceMove => true;
	public Swordsdance()
	{
		CurrentPowerPoints = PowerPoints;
	}
}