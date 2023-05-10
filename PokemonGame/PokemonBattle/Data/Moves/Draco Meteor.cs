using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Dracometeor : Move
{
	public override string Name => "Draco Meteor";
	public override string Description => "Comets are summoned down from the sky. The attack's recoil harshly reduces the user's Sp. Atk stat.";
	public override int BasePower => 130;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Dragon;
	public override bool IgnoresProtect => false;
	public Dracometeor()
	{
		CurrentPowerPoints = PowerPoints;
	}
}