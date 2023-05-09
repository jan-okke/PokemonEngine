using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Brickbreak : Move
{
	public override string Name => "Brick Break";
	public override string Description => "The user attacks with a swift chop. It can also break any barrier such as Light Screen and Reflect.";
	public override int BasePower => 75;
	public override int PowerPoints => 15;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Fighting;
	public override bool IsContactMove => true;
	public override bool IgnoresProtect => false;
	public Brickbreak()
	{
		CurrentPowerPoints = PowerPoints;
	}
}