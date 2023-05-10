using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Flail : Move
{
	public override string Name => "Flail";
	public override string Description => "The user flails about aimlessly to attack. It becomes more powerful the less HP the user has.";
	public override int BasePower => 1;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Normal;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Flail()
	{
		CurrentPowerPoints = PowerPoints;
	}
}