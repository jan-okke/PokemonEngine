using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Wickedblow : Move
{
	public override string Name => "Wicked Blow";
	public override string Description => "Strikes with a fierce blow through mastery of the Dark style. Always results in a critical hit.";
	public override int BasePower => 80;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Dark;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool CanMetronome => false;
	public Wickedblow()
	{
		CurrentPowerPoints = PowerPoints;
	}
}