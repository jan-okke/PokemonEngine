using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Frostbreath : Move
{
	public override string Name => "Frost Breath";
	public override string Description => "The user blows a cold breath on the target. This attack always results in a critical hit.";
	public override int BasePower => 60;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Ice;
	public override bool IgnoresProtect => false;
	public Frostbreath()
	{
		CurrentPowerPoints = PowerPoints;
	}
}