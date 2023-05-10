using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Nightdaze : Move
{
	public override string Name => "Night Daze";
	public override string Description => "The user lets loose a pitch-black shock wave at its target. It may also lower the target's accuracy.";
	public override int BasePower => 85;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 95;
	public override int EffectChance => 40;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Dark;
	public override bool IgnoresProtect => false;
	public Nightdaze()
	{
		CurrentPowerPoints = PowerPoints;
	}
}