using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Powder : Move
{
	public override string Name => "Powder";
	public override string Description => "The target is covered in a powder that explodes and damages it if it uses a Fire-type move.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Bug;
	public override bool IgnoresProtect => false;
	public override bool IsPowderMove => true;
	public Powder()
	{
		CurrentPowerPoints = PowerPoints;
	}
}