using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Rototiller : Move
{
	public override string Name => "Rototiller";
	public override string Description => "The user tills the soil to encourage plant growth. This raises the Attack and Sp. Atk of Grass types.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.AllBattlers;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Ground;
	public Rototiller()
	{
		CurrentPowerPoints = PowerPoints;
	}
}