using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Spikyshield : Move
{
	public override string Name => "Spiky Shield";
	public override string Description => "Protects the user from attacks. Also damages attackers that make contact with the user.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 4;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Grass;
	public Spikyshield()
	{
		CurrentPowerPoints = PowerPoints;
	}
}