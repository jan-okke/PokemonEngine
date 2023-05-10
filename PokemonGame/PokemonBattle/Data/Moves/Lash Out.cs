using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Lashout : Move
{
	public override string Name => "Lash Out";
	public override string Description => "The user lashes out to vent its frustration. Power is doubled if its stats dropped this turn.";
	public override int BasePower => 75;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Dark;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Lashout()
	{
		CurrentPowerPoints = PowerPoints;
	}
}