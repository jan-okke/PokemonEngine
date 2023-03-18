using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Impidimp : Pokemon
	{
		public override string Name => "Impidimp";
		public override List<Ability> AvailableAbilities => new() {new Prankster(), new Frisk() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Pickpocket() };
		public override Stats BaseStats => new Stats(45, 45, 30, 50, 55, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Fakeout(), new Confide() },
			[4] = new List<Move>() { new Bite() },
			[8] = new List<Move>() { new Flatter() },
			[12] = new List<Move>() { new Faketears() },
			[16] = new List<Move>() { new Assurance() },
			[20] = new List<Move>() { new Swagger() },
			[24] = new List<Move>() { new Suckerpunch() },
			[28] = new List<Move>() { new Torment() },
			[33] = new List<Move>() { new Darkpulse() },
			[36] = new List<Move>() { new Nastyplot() },
			[40] = new List<Move>() { new Playrough() },
			[44] = new List<Move>() { new Foulplay() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Burningjealousy(), new Darkpulse(), new Dazzlinggleam(), new Drainingkiss(), new Drainpunch(), new Endure(), new Facade(), new Faketears(), new Foulplay(), new Hiddenpower(), new Lashout(), new Leechlife(), new Lowkick(), new Megakick(), new Megapunch(), new Metronome(), new Nastyplot(), new Playrough(), new Protect(), new Rest(), new Retaliate(), new Revenge(), new Round(), new Sleeptalk(), new Snore(), new Substitute(), new Taunt(), new Thief(), new Thunderwave(), new Trick(), new Uproar() };
		public override int Weight => 55;
		public override int ExpYield => 53;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}