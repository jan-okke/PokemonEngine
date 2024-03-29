using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Clangingscales : Move
{
	public override string Name => "Clanging Scales";
	public override string Description => "The user rubs its scales and makes a huge noise. Also lowers the user's Defense stat.";
	public override int BasePower => 110;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.AllNearFoes;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Dragon;
	public override bool IgnoresProtect => false;
	public override bool IsSoundMove => true;
	public Clangingscales()
	{
		CurrentPowerPoints = PowerPoints;
	}
}