using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Faketears : Move
{
	public override string Name => "Fake Tears";
	public override string Description => "The user feigns crying to fluster the target, harshly lowering its Sp. Def stat.";
	public override int BasePower => 0;
	public override int PowerPoints => 20;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Dark;
	public override bool IgnoresProtect => false;
	public Faketears()
	{
		CurrentPowerPoints = PowerPoints;
	}
}