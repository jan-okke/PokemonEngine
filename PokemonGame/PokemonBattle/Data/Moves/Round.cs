using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Round : Move
{
	public override string Name => "Round";
	public override string Description => "The user attacks with a song. Others can join in the Round and make the attack do greater damage.";
	public override int BasePower => 60;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public override bool IsSoundMove => true;
	public Round()
	{
		CurrentPowerPoints = PowerPoints;
	}
}