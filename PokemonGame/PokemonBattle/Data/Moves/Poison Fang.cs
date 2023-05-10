using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Poisonfang : Move
{
	public override string Name => "Poison Fang";
	public override string Description => "The user bites the target with toxic fangs. It may also leave the target badly poisoned.";
	public override int BasePower => 50;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 50;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Poison;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool IsBitingMove => true;
	public Poisonfang()
	{
		CurrentPowerPoints = PowerPoints;
	}
}