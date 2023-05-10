using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Spacialrend : Move
{
	public override string Name => "Spacial Rend";
	public override string Description => "The user tears the target along with the space around it. Critical hits land more easily.";
	public override int BasePower => 100;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 95;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Dragon;
	public override bool IgnoresProtect => false;
	public override bool HasHighCriticalHitRate => true;
	public Spacialrend()
	{
		CurrentPowerPoints = PowerPoints;
	}
}