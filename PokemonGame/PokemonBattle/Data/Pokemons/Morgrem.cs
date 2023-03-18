using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Morgrem : Pokemon
	{
		public override string Name => "Morgrem";
		public override List<Ability> AvailableAbilities => new() {new Prankster(), new Frisk() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Pickpocket() };
		public override Stats BaseStats => new Stats(65, 60, 45, 70, 75, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Falsesurrender() },
			[1] = new List<Move>() { new Falsesurrender(), new Fakeout(), new Confide(), new Bite(), new Flatter() },
			[12] = new List<Move>() { new Faketears() },
			[16] = new List<Move>() { new Assurance() },
			[20] = new List<Move>() { new Swagger() },
			[24] = new List<Move>() { new Suckerpunch() },
			[28] = new List<Move>() { new Torment() },
			[35] = new List<Move>() { new Darkpulse() },
			[40] = new List<Move>() { new Nastyplot() },
			[46] = new List<Move>() { new Playrough() },
			[52] = new List<Move>() { new Foulplay() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Burningjealousy(), new Darkpulse(), new Dazzlinggleam(), new Drainingkiss(), new Drainpunch(), new Endure(), new Facade(), new Faketears(), new Foulplay(), new Hiddenpower(), new Lashout(), new Leechlife(), new Lightscreen(), new Lowkick(), new Megakick(), new Megapunch(), new Metronome(), new Nastyplot(), new Playrough(), new Protect(), new Reflect(), new Rest(), new Retaliate(), new Revenge(), new Round(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Substitute(), new Taunt(), new Thief(), new Throatchop(), new Thunderwave(), new Trick(), new Uproar() };
		public override int Weight => 125;
		public override int ExpYield => 130;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}