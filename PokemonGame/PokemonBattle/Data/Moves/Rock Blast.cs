using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Rockblast : Move
{
	public override string Name => "Rock Blast";
	public override string Description => "The user hurls hard rocks at the target. Two to five rocks are launched in quick succession.";
	public override int BasePower => 25;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Rock;
	public override bool IgnoresProtect => false;
	public override bool IsBombMove => true;
	public Rockblast()
	{
		CurrentPowerPoints = PowerPoints;
	}
}