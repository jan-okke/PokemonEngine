using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Sweetkiss : Move
{
	public override string Name => "Sweet Kiss";
	public override string Description => "The user kisses the target with a sweet, angelic cuteness that causes confusion.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 75;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Fairy;
	public override bool IgnoresProtect => false;
	public Sweetkiss()
	{
		CurrentPowerPoints = PowerPoints;
	}
}