using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Flameburst : Move
{
	public override string Name => "Flame Burst";
	public override string Description => "The user attacks the foe with a bursting flame. It also damages Pokémon next to the target.";
	public override int BasePower => 70;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Fire;
	public override bool IgnoresProtect => false;
	public Flameburst()
	{
		CurrentPowerPoints = PowerPoints;
	}
}