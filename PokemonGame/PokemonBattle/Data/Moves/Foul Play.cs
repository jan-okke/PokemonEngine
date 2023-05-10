using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Foulplay : Move
{
	public override string Name => "Foul Play";
	public override string Description => "The user turns the foe's power against it. It does more damage the higher the target's Attack stat.";
	public override int BasePower => 95;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Dark;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Foulplay()
	{
		CurrentPowerPoints = PowerPoints;
	}
}