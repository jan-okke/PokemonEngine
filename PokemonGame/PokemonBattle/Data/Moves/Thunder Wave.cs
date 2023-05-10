using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Thunderwave : Move
{
	public override string Name => "Thunder Wave";
	public override string Description => "A weak electric charge is launched at the target. It causes paralysis if it hits.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Electric;
	public override bool IgnoresProtect => false;
	public Thunderwave()
	{
		CurrentPowerPoints = PowerPoints;
	}
}