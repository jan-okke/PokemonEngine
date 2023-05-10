using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Starmie : Pokemon
{
	public override string Name => "Starmie";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Illuminate(), new Abilities.Naturalcure() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Analytic() };
	public override Stats BaseStats => new Stats(60, 75, 85, 100, 85, 115);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Rapidspin(), new Moves.Minimize(), new Moves.Swift(), new Moves.Psybeam(), new Moves.Brine(), new Moves.Lightscreen(), new Moves.Powergem(), new Moves.Psychic(), new Moves.Surf(), new Moves.Recover(), new Moves.Cosmicpower(), new Moves.Hydropump(), new Moves.Tackle(), new Moves.Harden(), new Moves.Watergun(), new Moves.Confuseray() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Allyswitch(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Brine(), new Moves.Cosmicpower(), new Moves.Dazzlinggleam(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Flash(), new Moves.Flashcannon(), new Moves.Flipturn(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gyroball(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Lightscreen(), new Moves.Meteorbeam(), new Moves.Powergem(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychocut(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Triattack(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Wonderroom() };
	public override int Weight => 800;
	public override int ExpYield => 182;
	public override int CatchRate => 60;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}