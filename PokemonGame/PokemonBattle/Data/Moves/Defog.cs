using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Defog : Move
{
	public override string Name => "Defog";
	public override string Description => "A strong wind blows away the foe's obstacles such as Light Screen. It also lowers their evasion.";
	public override int BasePower => 0;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Flying;
	public override bool IgnoresProtect => false;
	public Defog()
	{
		CurrentPowerPoints = PowerPoints;
	}
}