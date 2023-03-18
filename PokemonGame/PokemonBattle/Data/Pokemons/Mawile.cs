using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mawile : Pokemon
	{
		public override string Name => "Mawile";
		public override List<Ability> AvailableAbilities => new() {new Hypercutter(), new Intimidate() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sheerforce() };
		public override Stats BaseStats => new Stats(50, 85, 85, 50, 55, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Astonish(), new Growl() },
			[4] = new List<Move>() { new Fairywind() },
			[8] = new List<Move>() { new Batonpass() },
			[12] = new List<Move>() { new Bite() },
			[16] = new List<Move>() { new Stockpile(), new Swallow(), new Spitup() },
			[20] = new List<Move>() { new Suckerpunch() },
			[24] = new List<Move>() { new Irondefense() },
			[28] = new List<Move>() { new Crunch() },
			[32] = new List<Move>() { new Sweetscent() },
			[36] = new List<Move>() { new Ironhead() },
			[40] = new List<Move>() { new Taunt() },
			[44] = new List<Move>() { new Faketears() },
			[48] = new List<Move>() { new Playrough() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Batonpass(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Chargebeam(), new Crunch(), new Darkpulse(), new Doubleteam(), new Drainingkiss(), new Endure(), new Facade(), new Faketears(), new Falseswipe(), new Fireblast(), new Firefang(), new Flamethrower(), new Flashcannon(), new Fling(), new Focusblast(), new Focuspunch(), new Foulplay(), new Gigaimpact(), new Grassknot(), new Guardswap(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icefang(), new Icepunch(), new Icywind(), new Irondefense(), new Ironhead(), new Megakick(), new Megapunch(), new Mistyterrain(), new Payback(), new Playrough(), new Protect(), new Psychicfangs(), new Raindance(), new Rest(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Shadowball(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Stealthrock(), new Steelbeam(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Taunt(), new Thunderfang(), new Thunderpunch(), new Torment() };
		public override List<Move> EggMoves => new List<Move>() { new Ancientpower(), new Firefang(), new Guardswap(), new Icefang(), new Metalburst(), new Mistyterrain(), new Poisonfang(), new Poweruppunch(), new Seismictoss(), new Slam(), new Suckerpunch(), new Thunderfang(), new Tickle() };
		public override int Weight => 115;
		public override int ExpYield => 133;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}