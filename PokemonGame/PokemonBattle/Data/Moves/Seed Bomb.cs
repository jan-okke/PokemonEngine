using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Seedbomb : Move
{
	public override string Name => "Seed Bomb";
	public override string Description => "The user slams a barrage of hard-shelled seeds down on the target from above.";
	public override int BasePower => 80;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Grass;
	public override bool IgnoresProtect => false;
	public override bool IsBombMove => true;
	public Seedbomb()
	{
		CurrentPowerPoints = PowerPoints;
	}
}