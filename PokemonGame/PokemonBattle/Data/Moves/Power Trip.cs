using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Powertrip : Move
{
	public override string Name => "Power Trip";
	public override string Description => "The user boasts of its strength. Power increases the more the user's stats are raised.";
	public override int BasePower => 1;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Dark;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Powertrip()
	{
		CurrentPowerPoints = PowerPoints;
	}
}