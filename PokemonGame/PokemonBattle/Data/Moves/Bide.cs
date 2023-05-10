using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Bide : Move
{
	public override string Name => "Bide";
	public override string Description => "The user endures attacks for two turns, then strikes back to cause double the damage taken.";
	public override int BasePower => 1;
	public override int PowerPoints => 10;
	public override int Priority => 1;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.None;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Bide()
	{
		CurrentPowerPoints = PowerPoints;
	}
}