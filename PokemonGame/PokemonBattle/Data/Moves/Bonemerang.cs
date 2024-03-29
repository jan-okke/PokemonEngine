using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Bonemerang : Move
{
	public override string Name => "Bonemerang";
	public override string Description => "The user throws the bone it holds. The bone loops to hit the target twice, coming and going.";
	public override int BasePower => 50;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Ground;
	public override bool IgnoresProtect => false;
	public Bonemerang()
	{
		CurrentPowerPoints = PowerPoints;
	}
}