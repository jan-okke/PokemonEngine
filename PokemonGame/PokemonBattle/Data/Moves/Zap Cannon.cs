using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Zapcannon : Move
{
	public override string Name => "Zap Cannon";
	public override string Description => "The user fires an electric blast like a cannon to inflict damage and cause paralysis.";
	public override int BasePower => 120;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 50;
	public override int EffectChance => 100;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Electric;
	public override bool IgnoresProtect => false;
	public override bool IsBombMove => true;
	public Zapcannon()
	{
		CurrentPowerPoints = PowerPoints;
	}
}