using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Dreameater : Move
{
	public override string Name => "Dream Eater";
	public override string Description => "The user eats the dreams of a sleeping foe. It absorbs half the damage caused to heal the user's HP.";
	public override int BasePower => 100;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Psychic;
	public override bool IgnoresProtect => false;
	public Dreameater()
	{
		CurrentPowerPoints = PowerPoints;
	}
}