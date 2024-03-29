using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Weatherball : Move
{
	public override string Name => "Weather Ball";
	public override string Description => "An attack move that varies in power and type depending on the weather.";
	public override int BasePower => 50;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public override bool IsBombMove => true;
	public Weatherball()
	{
		CurrentPowerPoints = PowerPoints;
	}
}