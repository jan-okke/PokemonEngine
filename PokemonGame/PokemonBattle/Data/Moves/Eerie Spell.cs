using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Eeriespell : Move
{
	public override string Name => "Eerie Spell";
	public override string Description => "The user attacks with tremendous psychic power. This also removes 3 PP from the target's last move.";
	public override int BasePower => 80;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Psychic;
	public override bool IgnoresProtect => false;
	public override bool IsSoundMove => true;
	public Eeriespell()
	{
		CurrentPowerPoints = PowerPoints;
	}
}