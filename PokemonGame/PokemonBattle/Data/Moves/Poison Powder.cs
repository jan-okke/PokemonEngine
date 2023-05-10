using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Poisonpowder : Move
{
	public override string Name => "Poison Powder";
	public override string Description => "The user scatters a cloud of poisonous dust on the target. It may poison the target.";
	public override int BasePower => 0;
	public override int PowerPoints => 35;
	public override int Priority => 0;
	public override int Accuracy => 75;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Poison;
	public override bool IgnoresProtect => false;
	public override bool IsPowderMove => true;
	public Poisonpowder()
	{
		CurrentPowerPoints = PowerPoints;
	}
}