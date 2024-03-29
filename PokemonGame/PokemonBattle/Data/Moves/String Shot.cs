using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Stringshot : Move
{
	public override string Name => "String Shot";
	public override string Description => "The foe is bound with silk blown from the user's mouth. This silk reduces the target's Speed.";
	public override int BasePower => 0;
	public override int PowerPoints => 40;
	public override int Priority => 0;
	public override int Accuracy => 95;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.AllNearFoes;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Bug;
	public override bool IgnoresProtect => false;
	public Stringshot()
	{
		CurrentPowerPoints = PowerPoints;
	}
}