using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Selfdestruct : Move
{
	public override string Name => "Self-Destruct";
	public override string Description => "The user blows up to inflict damage on all Pokémon in battle. The user faints upon using this move.";
	public override int BasePower => 200;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.AllNearOthers;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IgnoresProtect => false;
	public Selfdestruct()
	{
		CurrentPowerPoints = PowerPoints;
	}
}