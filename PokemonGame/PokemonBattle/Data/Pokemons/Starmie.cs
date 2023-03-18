using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Starmie : Pokemon
	{
		public override string Name => "Starmie";
		public override List<Ability> AvailableAbilities => new() {new Illuminate(), new Naturalcure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Analytic() };
		public override Stats BaseStats => new Stats(60, 75, 85, 115, 100, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Rapidspin(), new Minimize(), new Swift(), new Psybeam(), new Brine(), new Lightscreen(), new Powergem(), new Psychic(), new Surf(), new Recover(), new Cosmicpower(), new Hydropump(), new Tackle(), new Harden(), new Watergun(), new Confuseray() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Allyswitch(), new Avalanche(), new Blizzard(), new Brine(), new Cosmicpower(), new Dazzlinggleam(), new Dive(), new Doubleteam(), new Dreameater(), new Endure(), new Expandingforce(), new Facade(), new Flash(), new Flashcannon(), new Flipturn(), new Gigaimpact(), new Grassknot(), new Gyroball(), new Hail(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Lightscreen(), new Meteorbeam(), new Powergem(), new Protect(), new Psychic(), new Psychocut(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Round(), new Scald(), new Skillswap(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Triattack(), new Trick(), new Trickroom(), new Waterfall(), new Waterpulse(), new Whirlpool(), new Wonderroom() };
		public override int Weight => 800;
		public override int ExpYield => 182;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}