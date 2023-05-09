using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Moves;

public class Beatup : Move
{
	public override string Name => "Beat Up";
	public override string Description => "The user gets all the party Pokémon to attack the foe. The more party Pokémon, the more damage.";
	public override int BasePower => 1;
	public override int PowerPoints => 10;
	public override int Priority => 0;
	public override int Accuracy => 100;
	public override int EffectChance => 0;
	public override MoveTarget Target => MoveTarget.NearOther;
	public override MoveCategory Category => MoveCategory.Physical;
	public override PokemonType Type => PokemonType.Dark;
	public override bool IgnoresProtect => false;
	public Beatup()
	{
		CurrentPowerPoints = PowerPoints;
	}
}