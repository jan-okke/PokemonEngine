using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Freezingglare : Move
{
	public override string Name => "Freezing Glare";
	public override string Description => "The user shoots its psychic power from its eyes to attack. This may also leave the target frozen.";
	public override int BasePower => 90;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 10;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Psychic;
	public override bool IgnoresProtect => false;
	public override bool CanMetronome => false;
	public Freezingglare()
	{
		CurrentPowerPoints = PowerPoints;
	}
}