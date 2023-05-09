using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Smellingsalts : Move
{
	public override string Name => "Smelling Salts";
	public override string Description => "This attack inflicts double damage on a paralyzed foe. It also cures the target's paralysis, however.";
	public override int BasePower => 70;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Smellingsalts()
	{
		CurrentPowerPoints = PowerPoints;
	}
}