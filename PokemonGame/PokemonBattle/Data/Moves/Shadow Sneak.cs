using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Shadowsneak : Move
{
	public override string Name => "Shadow Sneak";
	public override string Description => "The user extends its shadow and attacks the target from behind. This move always goes first.";
	public override int BasePower => 40;
	public override int PowerPoints => 30;
	public override int Priority => 1;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Ghost;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Shadowsneak()
	{
		CurrentPowerPoints = PowerPoints;
	}
}