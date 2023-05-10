using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Present : Move
{
	public override string Name => "Present";
	public override string Description => "The user attacks by giving the target a gift with a hidden trap. It restores HP sometimes, however.";
	public override int BasePower => 1;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public Present()
	{
		CurrentPowerPoints = PowerPoints;
	}
}