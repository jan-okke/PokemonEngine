using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Flareblitz : Move
{
	public override string Name => "Flare Blitz";
	public override string Description => "The user cloaks itself in fire and charges at the foe. The user also takes damage and may burn the target.";
	public override int BasePower => 120;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 10;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Fire;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool ThawsUser => true;
	public Flareblitz()
	{
		CurrentPowerPoints = PowerPoints;
	}
}