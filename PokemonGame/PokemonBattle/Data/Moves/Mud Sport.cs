using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Mudsport : Move
{
	public override string Name => "Mud Sport";
	public override string Description => "The user covers itself with mud. It weakens Electric-type moves while the user is in the battle.";
	public override int BasePower => 0;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.BothSides;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Ground;
	public Mudsport()
	{
		CurrentPowerPoints = PowerPoints;
	}
}