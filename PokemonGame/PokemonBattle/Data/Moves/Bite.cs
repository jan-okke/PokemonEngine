using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Bite : Move
{
	public override string Name => "Bite";
	public override string Description => "The target is bitten with viciously sharp fangs. It may make the target flinch.";
	public override int BasePower => 60;
	public override int PowerPoints => 25;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 30;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Dark;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool IsBitingMove => true;
	public Bite()
	{
		CurrentPowerPoints = PowerPoints;
	}
}