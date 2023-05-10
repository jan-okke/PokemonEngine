using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Foresight : Move
{
	public override string Name => "Foresight";
	public override string Description => "Enables the user to hit a Ghost type with any kind of move. It also enables the user to hit an evasive foe.";
	public override int BasePower => 0;
	public override int PowerPoints => 40;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public Foresight()
	{
		CurrentPowerPoints = PowerPoints;
	}
}