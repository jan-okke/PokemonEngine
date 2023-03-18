using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Staryu : Pokemon
	{
		public override string Name => "Staryu";
		public override List<Ability> AvailableAbilities => new() {new Illuminate(), new Naturalcure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Analytic() };
		public override Stats BaseStats => new Stats(30, 45, 55, 70, 55, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Harden() },
			[4] = new List<Move>() { new Watergun() },
			[8] = new List<Move>() { new Confuseray() },
			[12] = new List<Move>() { new Rapidspin() },
			[16] = new List<Move>() { new Minimize() },
			[20] = new List<Move>() { new Swift() },
			[24] = new List<Move>() { new Psybeam() },
			[28] = new List<Move>() { new Brine() },
			[32] = new List<Move>() { new Lightscreen() },
			[36] = new List<Move>() { new Powergem() },
			[40] = new List<Move>() { new Psychic() },
			[44] = new List<Move>() { new Surf() },
			[48] = new List<Move>() { new Recover() },
			[52] = new List<Move>() { new Cosmicpower() },
			[56] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Blizzard(), new Brine(), new Cosmicpower(), new Dazzlinggleam(), new Dive(), new Doubleteam(), new Endure(), new Facade(), new Flash(), new Flashcannon(), new Flipturn(), new Gyroball(), new Hail(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icywind(), new Lightscreen(), new Powergem(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Triattack(), new Waterfall(), new Waterpulse(), new Whirlpool() };
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
}