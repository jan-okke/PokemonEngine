using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Mistyexplosion : Move
{
	public override string Name => "Misty Explosion";
	public override string Description => "The user attacks everything around and faints upon using this move. Power increases on Misty Terrain.";
	public override int BasePower => 100;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.AllNearOthers;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Fairy;
	public override bool IgnoresProtect => false;
	public Mistyexplosion()
	{
		CurrentPowerPoints = PowerPoints;
	}
}