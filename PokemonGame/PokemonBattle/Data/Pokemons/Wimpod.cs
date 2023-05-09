using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Wimpod : Pokemon
{
	public override string Name => "Wimpod";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Wimpout() };
	public override Stats BaseStats => new Stats(25, 35, 40, 20, 30, 80);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Strugglebug(), new Moves.Sandattack(), new Moves.Defensecurl() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Bugbuzz(), new Moves.Endure(), new Moves.Facade(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Leechlife(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Screech(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Spikes(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swift(), new Moves.Taunt(), new Moves.Waterfall() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Aquajet(), new Moves.Harden(), new Moves.Metalclaw(), new Moves.Rollout(), new Moves.Wideguard() };
	public override int Weight => 120;
	public override int ExpYield => 46;
	public override int CatchRate => 90;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}