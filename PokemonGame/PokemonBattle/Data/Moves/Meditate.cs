using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Meditate : Move
{
	public override string Name => "Meditate";
	public override string Description => "The user meditates to awaken the power deep within its body and raise its Attack stat.";
	public override int BasePower => 0;
	public override int PowerPoints => 40;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Psychic;
	public Meditate()
	{
		CurrentPowerPoints = PowerPoints;
	}
}