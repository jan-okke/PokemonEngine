using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Boltbeak : Move
{
	public override string Name => "Bolt Beak";
	public override string Description => "Stabs the target with an electrified beak. Power is doubled if the user attacks first.";
	public override int BasePower => 85;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Electric;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Boltbeak()
	{
		CurrentPowerPoints = PowerPoints;
	}
}