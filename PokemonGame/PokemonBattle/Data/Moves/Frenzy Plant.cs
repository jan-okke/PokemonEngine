using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Frenzyplant : Move
{
	public override string Name => "Frenzy Plant";
	public override string Description => "The user slams the target with an enormous tree. The user can't move on the next turn.";
	public override int BasePower => 150;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Grass;
	public override bool IgnoresProtect => false;
	public Frenzyplant()
	{
		CurrentPowerPoints = PowerPoints;
	}
}