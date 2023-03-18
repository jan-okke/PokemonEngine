using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dracozolt : Pokemon
	{
		public override string Name => "Dracozolt";
		public override List<Ability> AvailableAbilities => new() {new Voltabsorb(), new Hustle() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandrush() };
		public override Stats BaseStats => new Stats(90, 100, 90, 80, 70, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Thundershock() },
			[7] = new List<Move>() { new Charge() },
			[14] = new List<Move>() { new Aerialace() },
			[21] = new List<Move>() { new Ancientpower() },
			[28] = new List<Move>() { new Pluck() },
			[35] = new List<Move>() { new Dragontail() },
			[42] = new List<Move>() { new Stomp() },
			[49] = new List<Move>() { new Slam() },
			[56] = new List<Move>() { new Discharge() },
			[63] = new List<Move>() { new Boltbeak() },
			[70] = new List<Move>() { new Dragonpulse() },
			[77] = new List<Move>() { new Dragonrush() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Bodyslam(), new Breakingswipe(), new Brutalswing(), new Bulldoze(), new Dracometeor(), new Dragonclaw(), new Dragonpulse(), new Earthpower(), new Earthquake(), new Electroball(), new Endure(), new Facade(), new Fireblast(), new Firefang(), new Firespin(), new Flamethrower(), new Gigaimpact(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Irontail(), new Lowkick(), new Megakick(), new Megapunch(), new Meteorbeam(), new Outrage(), new Protect(), new Raindance(), new Rest(), new Risingvoltage(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Sunnyday(), new Taunt(), new Thunder(), new Thunderbolt(), new Thunderfang(), new Thunderpunch(), new Thunderwave(), new Wildcharge() };
		public override int Weight => 1900;
		public override int ExpYield => 177;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}