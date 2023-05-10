using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Pyroball : Move
{
	public override string Name => "Pyro Ball";
	public override string Description => "Attacks by igniting a small stone and launching it as a fiery ball. May also burn the target.";
	public override int BasePower => 120;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 10;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Fire;
	public override bool IgnoresProtect => false;
	public override bool ThawsUser => true;
	public override bool IsBombMove => true;
	public override bool CanMetronome => false;
	public Pyroball()
	{
		CurrentPowerPoints = PowerPoints;
	}
}