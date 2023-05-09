using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Fleurcannon : Move
{
	public override string Name => "Fleur Cannon";
	public override string Description => "The user unleashes a strong beam. The attack's recoil harshly lowers the user's Sp. Atk stat.";
	public override int BasePower => 130;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Fairy;
	public override bool IgnoresProtect => false;
	public override bool CanMetronome => false;
	public Fleurcannon()
	{
		CurrentPowerPoints = PowerPoints;
	}
}