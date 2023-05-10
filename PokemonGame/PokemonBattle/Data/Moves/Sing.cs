using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Sing : Move
{
	public override string Name => "Sing";
	public override string Description => "A soothing lullaby is sung in a calming voice that puts the target into a deep slumber.";
	public override int BasePower => 0;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 55;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public override bool IsSoundMove => true;
	public Sing()
	{
		CurrentPowerPoints = PowerPoints;
	}
}