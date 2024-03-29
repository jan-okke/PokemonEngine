using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Burnup : Move
{
	public override string Name => "Burn Up";
	public override string Description => "To inflict massive damage, the user burns itself out. The user will no longer be Fire type.";
	public override int BasePower => 130;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Fire;
	public override bool IgnoresProtect => false;
	public override bool ThawsUser => true;
	public Burnup()
	{
		CurrentPowerPoints = PowerPoints;
	}
}