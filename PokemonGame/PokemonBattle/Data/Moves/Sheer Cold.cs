using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Sheercold : Move
{
	public override string Name => "Sheer Cold";
	public override string Description => "The foe is attacked with a blast of absolute-zero cold. The target instantly faints if it hits.";
	public override int BasePower => 1;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 30;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Ice;
	public override bool IgnoresProtect => false;
	public Sheercold()
	{
		CurrentPowerPoints = PowerPoints;
	}
}