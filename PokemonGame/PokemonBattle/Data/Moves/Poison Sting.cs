using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Poisonsting : Move
{
	public override string Name => "Poison Sting";
	public override string Description => "The user stabs the target with a poisonous stinger. This may also poison the target.";
	public override int BasePower => 15;
	public override int PowerPoints => 35;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 30;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Poison;
	public override bool IgnoresProtect => false;
	public Poisonsting()
	{
		CurrentPowerPoints = PowerPoints;
	}
}