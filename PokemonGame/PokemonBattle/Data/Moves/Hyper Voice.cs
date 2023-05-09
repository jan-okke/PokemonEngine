using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Hypervoice : Move
{
	public override string Name => "Hyper Voice";
	public override string Description => "The user lets loose a horribly echoing shout with the power to inflict damage.";
	public override int BasePower => 90;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.AllNearFoes;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public override bool IsSoundMove => true;
	public Hypervoice()
	{
		CurrentPowerPoints = PowerPoints;
	}
}