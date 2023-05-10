using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Thief : Move
{
	public override string Name => "Thief";
	public override string Description => "The user attacks and steals the foe's held item simultaneously. It can't steal if the user holds an item.";
	public override int BasePower => 60;
	public override int PowerPoints => 25;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Dark;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Thief()
	{
		CurrentPowerPoints = PowerPoints;
	}
}