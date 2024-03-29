using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Barrage : Move
{
	public override string Name => "Barrage";
	public override string Description => "Round objects are hurled at the target to strike two to five times in a row.";
	public override int BasePower => 15;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 85;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public override bool IsBombMove => true;
	public Barrage()
	{
		CurrentPowerPoints = PowerPoints;
	}
}