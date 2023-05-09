using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Grassknot : Move
{
	public override string Name => "Grass Knot";
	public override string Description => "The user snares the target with grass and trips it. The heavier the target, the greater the damage.";
	public override int BasePower => 1;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Grass;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Grassknot()
	{
		CurrentPowerPoints = PowerPoints;
	}
}