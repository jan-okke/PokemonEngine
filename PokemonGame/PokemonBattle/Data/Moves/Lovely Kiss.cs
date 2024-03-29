using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Lovelykiss : Move
{
	public override string Name => "Lovely Kiss";
	public override string Description => "With a scary face, the user tries to force a kiss on the target. If it suceeds, the target falls asleep.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 75;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public Lovelykiss()
	{
		CurrentPowerPoints = PowerPoints;
	}
}