using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Quash : Move
{
	public override string Name => "Quash";
	public override string Description => "The user suppresses the target and makes its move go last.";
	public override int BasePower => 0;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Dark;
	public override bool IgnoresProtect => false;
	public Quash()
	{
		CurrentPowerPoints = PowerPoints;
	}
}