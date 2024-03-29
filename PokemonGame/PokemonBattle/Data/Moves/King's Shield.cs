using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Kingsshield : Move
{
	public override string Name => "King's Shield";
	public override string Description => "Protects itself from damage. It also harshly lowers the Attack of attackers that make contact.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 4;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Steel;
	public Kingsshield()
	{
		CurrentPowerPoints = PowerPoints;
	}
}