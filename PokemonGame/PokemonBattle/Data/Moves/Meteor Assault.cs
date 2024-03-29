using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Meteorassault : Move
{
	public override string Name => "Meteor Assault";
	public override string Description => "The user attacks wildly with its thick leek. The user can't move on the next turn.";
	public override int BasePower => 150;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Fighting;
	public override bool IgnoresProtect => false;
	public override bool CanMetronome => false;
	public Meteorassault()
	{
		CurrentPowerPoints = PowerPoints;
	}
}