using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Perishsong : Move
{
	public override string Name => "Perish Song";
	public override string Description => "Any Pokémon that hears this song faints in three turns, unless it switches out of battle.";
	public override int BasePower => 0;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.AllBattlers;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsSoundMove => true;
	public Perishsong()
	{
		CurrentPowerPoints = PowerPoints;
	}
}