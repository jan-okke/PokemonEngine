using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Skyattack : Move
{
	public override string Name => "Sky Attack";
	public override string Description => "A second-turn attack move where critical hits land more easily. It may also make the target flinch.";
	public override int BasePower => 140;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 30;
	public override MoveTarget Target => MoveTarget.Other;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Flying;
	public override bool IgnoresProtect => false;
	public override bool HasHighCriticalHitRate => true;
	public Skyattack()
	{
		CurrentPowerPoints = PowerPoints;
	}
}