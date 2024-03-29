using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Tailslap : Move
{
	public override string Name => "Tail Slap";
	public override string Description => "The user attacks by striking the target with its hard tail. It hits the Pokémon two to five times in a row.";
	public override int BasePower => 25;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 85;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Tailslap()
	{
		CurrentPowerPoints = PowerPoints;
	}
}