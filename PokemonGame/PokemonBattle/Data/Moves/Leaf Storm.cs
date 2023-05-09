using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Leafstorm : Move
{
	public override string Name => "Leaf Storm";
	public override string Description => "A storm of sharp is whipped up. The attack's recoil harshly reduces the user's Sp. Atk stat.";
	public override int BasePower => 130;
	public override int PowerPoints => 5;
	public override int Priority => 0;
	public override int Accuracy => 90;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Special;
	public override PokemonType Type => PokemonType.Grass;
	public override bool IgnoresProtect => false;
	public Leafstorm()
	{
		CurrentPowerPoints = PowerPoints;
	}
}