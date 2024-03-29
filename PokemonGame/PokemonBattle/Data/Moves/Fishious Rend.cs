using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Fishiousrend : Move
{
	public override string Name => "Fishious Rend";
	public override string Description => "The user rends the target with its hard gills. Power doubles if the user moves first.";
	public override int BasePower => 85;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Water;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Fishiousrend()
	{
		CurrentPowerPoints = PowerPoints;
	}
}