using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Fairywind : Move
{
	public override string Name => "Fairy Wind";
	public override string Description => "The user stirs up a fairy wind and strikes the target with it.";
	public override int BasePower => 40;
	public override int PowerPoints => 30;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Fairy;
	public override bool IgnoresProtect => false;
	public Fairywind()
	{
		CurrentPowerPoints = PowerPoints;
	}
}