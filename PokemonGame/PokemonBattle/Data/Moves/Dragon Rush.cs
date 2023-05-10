using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Dragonrush : Move
{
	public override string Name => "Dragon Rush";
	public override string Description => "The user tackles the foe while exhibiting overwhelming menace. It may also make the target flinch.";
	public override int BasePower => 100;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 75;
	public override int EffectChance => 20;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Dragon;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool HasExtraDamageOnMinimize => true;
	public Dragonrush()
	{
		CurrentPowerPoints = PowerPoints;
	}
}