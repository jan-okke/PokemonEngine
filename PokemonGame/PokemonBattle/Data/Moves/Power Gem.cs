using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Powergem : Move
{
	public override string Name => "Power Gem";
	public override string Description => "The user attacks with a ray of light that sparkles as if it were made of gemstones.";
	public override int BasePower => 80;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Rock;
	public override bool IgnoresProtect => false;
	public Powergem()
	{
		CurrentPowerPoints = PowerPoints;
	}
}