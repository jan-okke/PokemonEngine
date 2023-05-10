using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Drumbeating : Move
{
	public override string Name => "Drum Beating";
	public override string Description => "The user plays its drum, controlling roots to attack. This also lowers the target's Speed stat.";
	public override int BasePower => 80;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 100;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Grass;
	public override bool IgnoresProtect => false;
	public override bool CanMetronome => false;
	public Drumbeating()
	{
		CurrentPowerPoints = PowerPoints;
	}
}