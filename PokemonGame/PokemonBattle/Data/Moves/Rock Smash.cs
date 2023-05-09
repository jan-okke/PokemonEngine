using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Rocksmash : Move
{
	public override string Name => "Rock Smash";
	public override string Description => "The user attacks with a punch that can shatter a rock. It may also lower the foe's Defense stat.";
	public override int BasePower => 40;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 50;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Fighting;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Rocksmash()
	{
		CurrentPowerPoints = PowerPoints;
	}
}