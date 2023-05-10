using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Bravebird : Move
{
	public override string Name => "Brave Bird";
	public override string Description => "The user tucks in its wings and charges from a low altitude. The user also takes serious damage.";
	public override int BasePower => 120;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.Other;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Flying;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Bravebird()
	{
		CurrentPowerPoints = PowerPoints;
	}
}