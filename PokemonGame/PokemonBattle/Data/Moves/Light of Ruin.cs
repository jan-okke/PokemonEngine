using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Lightofruin : Move
{
	public override string Name => "Light of Ruin";
	public override string Description => "Fires a powerful beam of light drawn from the Eternal Flower. It also damages the user a lot.";
	public override int BasePower => 140;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Fairy;
	public override bool IgnoresProtect => false;
	public override bool CanMetronome => false;
	public Lightofruin()
	{
		CurrentPowerPoints = PowerPoints;
	}
}