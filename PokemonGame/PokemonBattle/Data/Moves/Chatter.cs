using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Chatter : Move
{
	public override string Name => "Chatter";
	public override string Description => "The user attacks using a sound wave based on words it has learned. It may also confuse the target.";
	public override int BasePower => 65;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 100;
	public override MoveTarget Target => MoveTarget.Other;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Flying;
	public override bool IgnoresProtect => false;
	public override bool IsSoundMove => true;
	public Chatter()
	{
		CurrentPowerPoints = PowerPoints;
	}
}