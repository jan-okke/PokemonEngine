using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Peck : Move
{
	public override string Name => "Peck";
	public override string Description => "The target is jabbed with a sharply pointed beak or horn.";
	public override int BasePower => 35;
	public override int PowerPoints => 35;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.Other;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Flying;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Peck()
	{
		CurrentPowerPoints = PowerPoints;
	}
}