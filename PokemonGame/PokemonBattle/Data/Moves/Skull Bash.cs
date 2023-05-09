using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Skullbash : Move
{
	public override string Name => "Skull Bash";
	public override string Description => "The user tucks in its head to raise its Defense in the first turn, then rams the foe on the next turn.";
	public override int BasePower => 130;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Skullbash()
	{
		CurrentPowerPoints = PowerPoints;
	}
}