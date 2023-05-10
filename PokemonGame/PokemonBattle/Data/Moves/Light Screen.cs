using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Lightscreen : Move
{
	public override string Name => "Light Screen";
	public override string Description => "A wondrous wall of light is put up to suppress damage from special attacks for five turns.";
	public override int BasePower => 0;
	public override int PowerPoints => 30;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.UserSide;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Psychic;
	public Lightscreen()
	{
		CurrentPowerPoints = PowerPoints;
	}
}