using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Torment : Move
{
	public override string Name => "Torment";
	public override string Description => "The user torments and enrages the foe, making it incapable of using the same move twice in a row.";
	public override int BasePower => 0;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Dark;
	public override bool IgnoresProtect => false;
	public Torment()
	{
		CurrentPowerPoints = PowerPoints;
	}
}