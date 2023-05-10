using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Spitup : Move
{
	public override string Name => "Spit Up";
	public override string Description => "The power stored using the move Stockpile is released all at once in an attack.";
	public override int BasePower => 1;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public Spitup()
	{
		CurrentPowerPoints = PowerPoints;
	}
}