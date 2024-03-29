using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Outrage : Move
{
	public override string Name => "Outrage";
	public override string Description => "The user rampages and attacks for two to three turns. It then becomes confused, however.";
	public override int BasePower => 120;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.RandomNearFoe;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Dragon;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Outrage()
	{
		CurrentPowerPoints = PowerPoints;
	}
}