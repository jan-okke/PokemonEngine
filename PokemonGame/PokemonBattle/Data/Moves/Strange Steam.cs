using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Strangesteam : Move
{
	public override string Name => "Strange Steam";
	public override string Description => "The user attacks the target by emitting steam. This may also confuse the target.";
	public override int BasePower => 90;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 95;
	public override int EffectChance => 20;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Fairy;
	public override bool IgnoresProtect => false;
	public override bool CanMetronome => false;
	public Strangesteam()
	{
		CurrentPowerPoints = PowerPoints;
	}
}