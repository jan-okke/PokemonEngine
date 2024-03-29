using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Dragonclaw : Move
{
	public override string Name => "Dragon Claw";
	public override string Description => "The user slashes the target with huge, sharp claws.";
	public override int BasePower => 80;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Dragon;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Dragonclaw()
	{
		CurrentPowerPoints = PowerPoints;
	}
}