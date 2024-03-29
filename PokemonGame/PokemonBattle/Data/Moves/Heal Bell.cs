using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Healbell : Move
{
	public override string Name => "Heal Bell";
	public override string Description => "The user makes a soothing bell chime to heal the status problems of all the party Pokémon.";
	public override int BasePower => 0;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.UserAndAllies;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsSoundMove => true;
	public Healbell()
	{
		CurrentPowerPoints = PowerPoints;
	}
}