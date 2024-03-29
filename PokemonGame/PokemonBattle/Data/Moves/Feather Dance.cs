using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Featherdance : Move
{
	public override string Name => "Feather Dance";
	public override string Description => "The user covers the target's body with a mass of down that harshly lowers its Attack stat.";
	public override int BasePower => 0;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Flying;
	public override bool IgnoresProtect => false;
	public override bool IsDanceMove => true;
	public Featherdance()
	{
		CurrentPowerPoints = PowerPoints;
	}
}