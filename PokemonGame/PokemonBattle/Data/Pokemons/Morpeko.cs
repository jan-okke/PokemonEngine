using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Morpeko : Pokemon
	{
		public override string Name => "Morpeko";
		public override List<Ability> AvailableAbilities => new() {new Hungerswitch() };
		public override Stats BaseStats => new Stats(58, 95, 58, 70, 58, 97);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Thundershock(), new Tailwhip() },
			[5] = new List<Move>() { new Leer() },
			[10] = new List<Move>() { new Powertrip() },
			[15] = new List<Move>() { new Quickattack() },
			[20] = new List<Move>() { new Flatter() },
			[25] = new List<Move>() { new Bite() },
			[30] = new List<Move>() { new Spark() },
			[35] = new List<Move>() { new Torment() },
			[40] = new List<Move>() { new Agility() },
			[45] = new List<Move>() { new Bulletseed() },
			[50] = new List<Move>() { new Crunch() },
			[55] = new List<Move>() { new Aurawheel() },
			[60] = new List<Move>() { new Thrash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Assurance(), new Attract(), new Brickbreak(), new Bulletseed(), new Crunch(), new Darkpulse(), new Electricterrain(), new Electroball(), new Electroweb(), new Endure(), new Facade(), new Faketears(), new Firefang(), new Fling(), new Foulplay(), new Hiddenpower(), new Icefang(), new Lashout(), new Nastyplot(), new Outrage(), new Payback(), new Protect(), new Psychicfangs(), new Rest(), new Revenge(), new Risingvoltage(), new Round(), new Scaryface(), new Seedbomb(), new Sleeptalk(), new Snarl(), new Snore(), new Stompingtantrum(), new Substitute(), new Swift(), new Taunt(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderfang(), new Thunderpunch(), new Thunderwave(), new Uproar(), new Voltswitch(), new Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Charge(), new Fakeout(), new Partingshot(), new Quash(), new Rapidspin(), new Superfang(), new Swagger(), new Tickle() };
		public override int Weight => 30;
		public override int ExpYield => 153;
		public override int CatchRate => 180;
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