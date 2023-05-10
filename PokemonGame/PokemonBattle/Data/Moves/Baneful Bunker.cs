using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Banefulbunker : Move
{
	public override string Name => "Baneful Bunker";
	public override string Description => "Protects the user from attacks. Also poisons any attacker that makes contact with the user.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 4;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Poison;
	public Banefulbunker()
	{
		CurrentPowerPoints = PowerPoints;
	}
}