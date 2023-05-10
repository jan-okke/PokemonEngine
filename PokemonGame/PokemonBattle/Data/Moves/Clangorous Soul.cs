using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Clangoroussoul : Move
{
	public override string Name => "Clangorous Soul";
	public override string Description => "The user raises all its stats by using some of its HP.";
	public override int BasePower => 0;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Dragon;
	public override bool IsSoundMove => true;
	public override bool CanMetronome => false;
	public Clangoroussoul()
	{
		CurrentPowerPoints = PowerPoints;
	}
}