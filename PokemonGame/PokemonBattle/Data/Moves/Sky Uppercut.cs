using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Skyuppercut : Move
{
	public override string Name => "Sky Uppercut";
	public override string Description => "The user attacks the target with an uppercut thrown skyward with force.";
	public override int BasePower => 85;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Fighting;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public override bool IsPunchingMove => true;
	public Skyuppercut()
	{
		CurrentPowerPoints = PowerPoints;
	}
}