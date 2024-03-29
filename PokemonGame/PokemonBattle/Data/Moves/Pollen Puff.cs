using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Pollenpuff : Move
{
	public override string Name => "Pollen Puff";
	public override string Description => "Fires an exploding pollen puff at enemies, or a HP-restoring one at allies.";
	public override int BasePower => 90;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Bug;
	public override bool IgnoresProtect => false;
	public override bool IsBombMove => true;
	public Pollenpuff()
	{
		CurrentPowerPoints = PowerPoints;
	}
}