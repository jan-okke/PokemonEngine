using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Heavyslam : Move
{
	public override string Name => "Heavy Slam";
	public override string Description => "The user slams into the foe with its heavy body. The heavier the user, the greater the damage.";
	public override int BasePower => 1;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Steel;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool HasExtraDamageOnMinimize => true;
	public Heavyslam()
	{
		CurrentPowerPoints = PowerPoints;
	}
}