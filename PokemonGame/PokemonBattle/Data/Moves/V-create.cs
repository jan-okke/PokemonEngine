using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Vcreate : Move
{
	public override string Name => "V-create";
	public override string Description => "With a fiery forehead, the user hurls itself at the foe. It lowers the user's Defense, Sp. Def, and Speed.";
	public override int BasePower => 180;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 95;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Fire;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool CanMetronome => false;
	public Vcreate()
	{
		CurrentPowerPoints = PowerPoints;
	}
}