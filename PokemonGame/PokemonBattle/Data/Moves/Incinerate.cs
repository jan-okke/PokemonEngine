using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Incinerate : Move
{
	public override string Name => "Incinerate";
	public override string Description => "The user attacks the foe with fire. The target's held Berry becomes burnt up and unusable.";
	public override int BasePower => 60;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.AllNearFoes;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Fire;
	public override bool IgnoresProtect => false;
	public Incinerate()
	{
		CurrentPowerPoints = PowerPoints;
	}
}