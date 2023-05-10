using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Knockoff : Move
{
	public override string Name => "Knock Off";
	public override string Description => "The user slaps down the target's held item, preventing that item from being used in the battle.";
	public override int BasePower => 65;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Dark;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Knockoff()
	{
		CurrentPowerPoints = PowerPoints;
	}
}