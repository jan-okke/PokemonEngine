using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Doublekick : Move
{
	public override string Name => "Double Kick";
	public override string Description => "The target is quickly kicked twice in succession using both feet.";
	public override int BasePower => 30;
	public override int PowerPoints => 30;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Fighting;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Doublekick()
	{
		CurrentPowerPoints = PowerPoints;
	}
}