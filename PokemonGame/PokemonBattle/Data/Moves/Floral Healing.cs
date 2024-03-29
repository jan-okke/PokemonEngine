using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Floralhealing : Move
{
	public override string Name => "Floral Healing";
	public override string Description => "The user restores the target's HP by up to half of its max HP. It restores more HP when the terrain is grass.";
	public override int BasePower => 0;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 0;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Status;
	public override PokemonType Type => PokemonType.Fairy;
	public override bool IgnoresProtect => false;
	public Floralhealing()
	{
		CurrentPowerPoints = PowerPoints;
	}
}