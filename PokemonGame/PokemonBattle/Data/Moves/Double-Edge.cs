using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Doubleedge : Move
{
	public override string Name => "Double-Edge";
	public override string Description => "A reckless, life-risking tackle. It also damages the user by a fairly large amount, however.";
	public override int BasePower => 120;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Doubleedge()
	{
		CurrentPowerPoints = PowerPoints;
	}
}