using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Kinesis : Move
{
	public override string Name => "Kinesis";
	public override string Description => "The user distracts the target by bending a spoon. It lowers the target's accuracy.";
	public override int BasePower => 0;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 80;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Psychic;
	public override bool IgnoresProtect => false;
	public Kinesis()
	{
		CurrentPowerPoints = PowerPoints;
	}
}