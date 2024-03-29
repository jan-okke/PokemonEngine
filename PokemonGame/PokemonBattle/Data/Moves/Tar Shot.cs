using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Tarshot : Move
{
	public override string Name => "Tar Shot";
	public override string Description => "Pours sticky tar over the target, lowering its Speed and making it weaker to Fire-type moves.";
	public override int BasePower => 0;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Rock;
	public override bool IgnoresProtect => false;
	public Tarshot()
	{
		CurrentPowerPoints = PowerPoints;
	}
}