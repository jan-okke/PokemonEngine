using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Psychocut : Move
{
	public override string Name => "Psycho Cut";
	public override string Description => "The user tears at the target with blades formed by psychic power. Critical hits land more easily.";
	public override int BasePower => 70;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Psychic;
	public override bool IgnoresProtect => false;
	public override bool HasHighCriticalHitRate => true;
	public Psychocut()
	{
		CurrentPowerPoints = PowerPoints;
	}
}