using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Bulletseed : Move
{
	public override string Name => "Bullet Seed";
	public override string Description => "The user forcefully shoots seeds at the target. Two to five seeds are shot in rapid succession.";
	public override int BasePower => 25;
	public override int PowerPoints => 30;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Grass;
	public override bool IgnoresProtect => false;
	public override bool IsBombMove => true;
	public Bulletseed()
	{
		CurrentPowerPoints = PowerPoints;
	}
}