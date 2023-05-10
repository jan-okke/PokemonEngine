using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Furyattack : Move
{
	public override string Name => "Fury Attack";
	public override string Description => "The target is jabbed repeatedly with a horn or beak two to five times in a row.";
	public override int BasePower => 15;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 85;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Furyattack()
	{
		CurrentPowerPoints = PowerPoints;
	}
}