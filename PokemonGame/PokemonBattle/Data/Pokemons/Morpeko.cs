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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Hungerswitch() };
		public override Stats BaseStats => new Stats(58, 95, 58, 70, 58, 97);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Thundershock(), new Moves.Tailwhip() },
			[5] = new List<Move>() { new Moves.Leer() },
			[10] = new List<Move>() { new Moves.Powertrip() },
			[15] = new List<Move>() { new Moves.Quickattack() },
			[20] = new List<Move>() { new Moves.Flatter() },
			[25] = new List<Move>() { new Moves.Bite() },
			[30] = new List<Move>() { new Moves.Spark() },
			[35] = new List<Move>() { new Moves.Torment() },
			[40] = new List<Move>() { new Moves.Agility() },
			[45] = new List<Move>() { new Moves.Bulletseed() },
			[50] = new List<Move>() { new Moves.Crunch() },
			[55] = new List<Move>() { new Moves.Aurawheel() },
			[60] = new List<Move>() { new Moves.Thrash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bulletseed(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Electricterrain(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Firefang(), new Moves.Fling(), new Moves.Foulplay(), new Moves.Hiddenpower(), new Moves.Icefang(), new Moves.Lashout(), new Moves.Nastyplot(), new Moves.Outrage(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Rest(), new Moves.Revenge(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Scaryface(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderfang(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Voltswitch(), new Moves.Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Charge(), new Moves.Fakeout(), new Moves.Partingshot(), new Moves.Quash(), new Moves.Rapidspin(), new Moves.Superfang(), new Moves.Swagger(), new Moves.Tickle() };
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