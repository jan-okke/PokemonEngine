using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Confusion : Move
{
	public override string Name => "Confusion";
	public override string Description => "The target is hit by a weak telekinetic force. It may also leave the target confused.";
	public override int BasePower => 50;
	public override int PowerPoints => 25;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 10;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Psychic;
	public override bool IgnoresProtect => false;
	public Confusion()
	{
		CurrentPowerPoints = PowerPoints;
	}
}