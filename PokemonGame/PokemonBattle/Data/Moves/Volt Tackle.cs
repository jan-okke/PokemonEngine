using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Volttackle : Move
{
	public override string Name => "Volt Tackle";
	public override string Description => "The user electrifies itself, then charges at the foe. It causes considerable damage to the user as well.";
	public override int BasePower => 120;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 10;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Electric;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Volttackle()
	{
		CurrentPowerPoints = PowerPoints;
	}
}