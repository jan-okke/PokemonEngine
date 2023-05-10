using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Tropkick : Move
{
	public override string Name => "Trop Kick";
	public override string Description => "The user lands an intense tropical kick on the target. This also lowers the target's Attack stat.";
	public override int BasePower => 70;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 100;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Grass;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Tropkick()
	{
		CurrentPowerPoints = PowerPoints;
	}
}