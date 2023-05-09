using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Odorsleuth : Move
{
	public override string Name => "Odor Sleuth";
	public override string Description => "Enables the user to hit a Ghost type with any type of move. It also enables the user to hit an evasive foe.";
	public override int BasePower => 0;
	public override int PowerPoints => 40;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public Odorsleuth()
	{
		CurrentPowerPoints = PowerPoints;
	}
}