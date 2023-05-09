using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Staryu : Pokemon
{
	public override string Name => "Staryu";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Illuminate(), new Abilities.Naturalcure() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Analytic() };
	public override Stats BaseStats => new Stats(30, 45, 55, 70, 55, 85);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Harden() },
		[4] = new List<Move>() { new Moves.Watergun() },
		[8] = new List<Move>() { new Moves.Confuseray() },
		[12] = new List<Move>() { new Moves.Rapidspin() },
		[16] = new List<Move>() { new Moves.Minimize() },
		[20] = new List<Move>() { new Moves.Swift() },
		[24] = new List<Move>() { new Moves.Psybeam() },
		[28] = new List<Move>() { new Moves.Brine() },
		[32] = new List<Move>() { new Moves.Lightscreen() },
		[36] = new List<Move>() { new Moves.Powergem() },
		[40] = new List<Move>() { new Moves.Psychic() },
		[44] = new List<Move>() { new Moves.Surf() },
		[48] = new List<Move>() { new Moves.Recover() },
		[52] = new List<Move>() { new Moves.Cosmicpower() },
		[56] = new List<Move>() { new Moves.Hydropump() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Blizzard(), new Moves.Brine(), new Moves.Cosmicpower(), new Moves.Dazzlinggleam(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Flashcannon(), new Moves.Flipturn(), new Moves.Gyroball(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Lightscreen(), new Moves.Powergem(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Triattack(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override int Weight => 345;
	public override int ExpYield => 68;
	public override int CatchRate => 225;
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