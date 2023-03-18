using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Grimmsnarl : Pokemon
	{
		public override string Name => "Grimmsnarl";
		public override List<Ability> AvailableAbilities => new() {new Prankster(), new Frisk() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Pickpocket() };
		public override Stats BaseStats => new Stats(95, 120, 65, 95, 75, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Spiritbreak() },
			[1] = new List<Move>() { new Spiritbreak(), new Falsesurrender(), new Bulkup(), new Poweruppunch(), new Fakeout(), new Confide(), new Bite(), new Flatter() },
			[12] = new List<Move>() { new Faketears() },
			[16] = new List<Move>() { new Assurance() },
			[20] = new List<Move>() { new Swagger() },
			[24] = new List<Move>() { new Suckerpunch() },
			[28] = new List<Move>() { new Torment() },
			[35] = new List<Move>() { new Darkpulse() },
			[40] = new List<Move>() { new Nastyplot() },
			[48] = new List<Move>() { new Playrough() },
			[56] = new List<Move>() { new Foulplay() },
			[64] = new List<Move>() { new Hammerarm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Bodypress(), new Bodyslam(), new Brickbreak(), new Bulkup(), new Burningjealousy(), new Crunch(), new Darkestlariat(), new Darkpulse(), new Dazzlinggleam(), new Drainingkiss(), new Drainpunch(), new Endure(), new Facade(), new Faketears(), new Firepunch(), new Focusblast(), new Focusenergy(), new Foulplay(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Lashout(), new Leechlife(), new Lightscreen(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Metronome(), new Nastyplot(), new Playrough(), new Powerswap(), new Powerwhip(), new Protect(), new Reflect(), new Rest(), new Retaliate(), new Revenge(), new Round(), new Scaryface(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Substitute(), new Superpower(), new Taunt(), new Thief(), new Throatchop(), new Thunderpunch(), new Thunderwave(), new Trick(), new Uproar(), new Wonderroom() };
		public override int Weight => 610;
		public override int ExpYield => 255;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}