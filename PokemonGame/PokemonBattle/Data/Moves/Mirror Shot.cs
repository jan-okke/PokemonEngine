using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Mirrorshot : Move
{
	public override string Name => "Mirror Shot";
	public override string Description => "The user looses a flash of energy from its polished body. It may also lower the target's accuracy.";
	public override int BasePower => 65;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 85;
	public override int EffectChance => 30;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Steel;
	public override bool IgnoresProtect => false;
	public Mirrorshot()
	{
		CurrentPowerPoints = PowerPoints;
	}
}