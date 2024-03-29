using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Behemothblade : Move
{
	public override string Name => "Behemoth Blade";
	public override string Description => "The user becomes a gigantic sword and cuts the target.";
	public override int BasePower => 100;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Steel;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool CanMetronome => false;
	public Behemothblade()
	{
		CurrentPowerPoints = PowerPoints;
	}
}