using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Firelash : Move
{
	public override string Name => "Fire Lash";
	public override string Description => "The user strikes the target with a burning lash. This also lowers the target's Defense stat.";
	public override int BasePower => 80;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 100;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Fire;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Firelash()
	{
		CurrentPowerPoints = PowerPoints;
	}
}