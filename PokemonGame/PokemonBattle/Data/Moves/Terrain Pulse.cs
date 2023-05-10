using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Terrainpulse : Move
{
	public override string Name => "Terrain Pulse";
	public override string Description => "Utilizes the power of the terrain to attack. This move's type and power vary with the terrain.";
	public override int BasePower => 50;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public override bool IsPulseMove => true;
	public Terrainpulse()
	{
		CurrentPowerPoints = PowerPoints;
	}
}