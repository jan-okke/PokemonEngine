using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Retaliate : Move
{
	public override string Name => "Retaliate";
	public override string Description => "Gets revenge for a fainted ally. If an ally fainted in the last turn, this attack's damage increases.";
	public override int BasePower => 70;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Retaliate()
	{
		CurrentPowerPoints = PowerPoints;
	}
}