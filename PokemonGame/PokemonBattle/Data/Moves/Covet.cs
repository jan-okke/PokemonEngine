using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Covet : Move
{
	public override string Name => "Covet";
	public override string Description => "The user endearingly approaches the target, then steals the target's held item.";
	public override int BasePower => 60;
	public override int PowerPoints => 25;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Covet()
	{
		CurrentPowerPoints = PowerPoints;
	}
}