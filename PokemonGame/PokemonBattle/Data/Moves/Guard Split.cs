using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Guardsplit : Move
{
	public override string Name => "Guard Split";
	public override string Description => "The user employs its psychic power to average its Defense and Sp. Def stats with those of its target.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Psychic;
	public override bool IgnoresProtect => false;
	public Guardsplit()
	{
		CurrentPowerPoints = PowerPoints;
	}
}