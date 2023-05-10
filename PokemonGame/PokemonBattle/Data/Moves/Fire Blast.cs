using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Fireblast : Move
{
	public override string Name => "Fire Blast";
	public override string Description => "The foe is attacked with an intense blast of all-consuming fire. It may also leave the target with a burn.";
	public override int BasePower => 110;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 85;
	public override int EffectChance => 10;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Fire;
	public override bool IgnoresProtect => false;
	public Fireblast()
	{
		CurrentPowerPoints = PowerPoints;
	}
}