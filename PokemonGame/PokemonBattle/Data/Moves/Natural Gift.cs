using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Naturalgift : Move
{
	public override string Name => "Natural Gift";
	public override string Description => "The user draws power to attack by using its held Berry. The Berry determines its type and power.";
	public override int BasePower => 1;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public Naturalgift()
	{
		CurrentPowerPoints = PowerPoints;
	}
}