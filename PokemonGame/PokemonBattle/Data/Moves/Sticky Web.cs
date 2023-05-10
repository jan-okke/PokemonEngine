using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Stickyweb : Move
{
	public override string Name => "Sticky Web";
	public override string Description => "Weaves a sticky net around the opposing team, which lowers their Speed stats upon switching in.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.FoeSide;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Bug;
	public Stickyweb()
	{
		CurrentPowerPoints = PowerPoints;
	}
}