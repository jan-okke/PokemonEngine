using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Dragonascent : Move
{
	public override string Name => "Dragon Ascent";
	public override string Description => "The user soars upward and drops at high speeds. Its Defense and Sp. Def stats are lowered.";
	public override int BasePower => 120;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Flying;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool CanMetronome => false;
	public Dragonascent()
	{
		CurrentPowerPoints = PowerPoints;
	}
}