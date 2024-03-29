using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Petalblizzard : Move
{
	public override string Name => "Petal Blizzard";
	public override string Description => "The user stirs up a violent petal blizzard and attacks everything around it.";
	public override int BasePower => 90;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.AllNearOthers;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Grass;
	public override bool IgnoresProtect => false;
	public Petalblizzard()
	{
		CurrentPowerPoints = PowerPoints;
	}
}