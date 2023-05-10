using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Guillotine : Move
{
	public override string Name => "Guillotine";
	public override string Description => "A vicious, tearing attack with big pincers. The target will faint instantly if this attack hits.";
	public override int BasePower => 1;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 30;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Guillotine()
	{
		CurrentPowerPoints = PowerPoints;
	}
}