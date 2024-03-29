using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Appleacid : Move
{
	public override string Name => "Apple Acid";
	public override string Description => "Attacks with an acidic liquid created from tart apples. This also lowers the target's Sp. Def.";
	public override int BasePower => 80;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 100;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Grass;
	public override bool IgnoresProtect => false;
	public override bool CanMetronome => false;
	public Appleacid()
	{
		CurrentPowerPoints = PowerPoints;
	}
}