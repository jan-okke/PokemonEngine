using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Assurance : Move
{
	public override string Name => "Assurance";
	public override string Description => "If the target has already taken some damage in the same turn, this attack's power is doubled.";
	public override int BasePower => 60;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Dark;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Assurance()
	{
		CurrentPowerPoints = PowerPoints;
	}
}