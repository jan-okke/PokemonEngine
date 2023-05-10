using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Iceburn : Move
{
	public override string Name => "Ice Burn";
	public override string Description => "On the second turn, an ultracold, freezing wind surrounds the foe. This may leave it with a burn.";
	public override int BasePower => 140;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 30;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Ice;
	public override bool IgnoresProtect => false;
	public override bool CanMetronome => false;
	public Iceburn()
	{
		CurrentPowerPoints = PowerPoints;
	}
}