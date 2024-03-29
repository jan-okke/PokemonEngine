using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Headbutt : Move
{
	public override string Name => "Headbutt";
	public override string Description => "The user sticks out its head and attacks by charging into the foe. It may also make the target flinch.";
	public override int BasePower => 70;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 30;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Headbutt()
	{
		CurrentPowerPoints = PowerPoints;
	}
}