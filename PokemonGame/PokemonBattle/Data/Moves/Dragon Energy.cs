using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Dragonenergy : Move
{
	public override string Name => "Dragon Energy";
	public override string Description => "Converts life-force into power to attack. The lower the user's HP, the lower the move's power.";
	public override int BasePower => 150;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.AllNearFoes;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Dragon;
	public override bool IgnoresProtect => false;
	public override bool CanMetronome => false;
	public Dragonenergy()
	{
		CurrentPowerPoints = PowerPoints;
	}
}