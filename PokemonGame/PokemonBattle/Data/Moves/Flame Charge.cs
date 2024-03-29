using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Flamecharge : Move
{
	public override string Name => "Flame Charge";
	public override string Description => "The user cloaks itself in flame and attacks. Building up more power, it raises the user's Speed stat.";
	public override int BasePower => 50;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 100;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Fire;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Flamecharge()
	{
		CurrentPowerPoints = PowerPoints;
	}
}