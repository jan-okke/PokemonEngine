using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Tripleaxel : Move
{
	public override string Name => "Triple Axel";
	public override string Description => "A consecutive three-kick attack that becomes more powerful with each successful hit.";
	public override int BasePower => 20;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Ice;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Tripleaxel()
	{
		CurrentPowerPoints = PowerPoints;
	}
}