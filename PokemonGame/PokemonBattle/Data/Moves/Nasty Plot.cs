using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Nastyplot : Move
{
	public override string Name => "Nasty Plot";
	public override string Description => "The user stimulates its brain by thinking bad thoughts. It sharply raises the user's Sp. Atk.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.User;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Dark;
	public Nastyplot()
	{
		CurrentPowerPoints = PowerPoints;
	}
}