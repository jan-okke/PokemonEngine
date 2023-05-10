using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Aurawheel : Move
{
	public override string Name => "Aura Wheel";
	public override string Description => "Morpeko attacks and raises its Speed with energy stored in its cheeks. Type changes with the user's form.";
	public override int BasePower => 110;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 100;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Electric;
	public override bool IgnoresProtect => false;
	public override bool CanMetronome => false;
	public Aurawheel()
	{
		CurrentPowerPoints = PowerPoints;
	}
}