using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Soak : Move
{
	public override string Name => "Soak";
	public override string Description => "The user shoots a torrent of water at the target and changes the target's type to Water.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Water;
	public override bool IgnoresProtect => false;
	public Soak()
	{
		CurrentPowerPoints = PowerPoints;
	}
}