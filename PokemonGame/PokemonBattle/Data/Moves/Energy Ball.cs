using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Energyball : Move
{
	public override string Name => "Energy Ball";
	public override string Description => "The user draws power from nature and fires it at the target. It may also lower the target's Sp. Def.";
	public override int BasePower => 90;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 10;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Grass;
	public override bool IgnoresProtect => false;
	public override bool IsBombMove => true;
	public Energyball()
	{
		CurrentPowerPoints = PowerPoints;
	}
}