using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Mirrorcoat : Move
{
	public override string Name => "Mirror Coat";
	public override string Description => "A retaliation move that counters any special attack, inflicting double the damage taken.";
	public override int BasePower => 1;
	public override int PowerPoints => 20;
	public override int Priority => -5;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.None;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Psychic;
	public override bool IgnoresProtect => false;
	public Mirrorcoat()
	{
		CurrentPowerPoints = PowerPoints;
	}
}