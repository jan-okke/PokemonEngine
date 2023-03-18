using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tyranitar : Pokemon
	{
		public override string Name => "Tyranitar";
		public override List<Ability> AvailableAbilities => new() {new Sandstream() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unnerve() };
		public override Stats BaseStats => new Stats(100, 134, 110, 61, 95, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Irondefense(), new Thunderfang(), new Icefang(), new Firefang(), new Tackle(), new Leer(), new Rockthrow(), new Payback() },
			[9] = new List<Move>() { new Bite() },
			[12] = new List<Move>() { new Scaryface() },
			[15] = new List<Move>() { new Rockslide() },
			[18] = new List<Move>() { new Stompingtantrum() },
			[21] = new List<Move>() { new Screech() },
			[24] = new List<Move>() { new Darkpulse() },
			[27] = new List<Move>() { new Crunch() },
			[33] = new List<Move>() { new Earthquake() },
			[37] = new List<Move>() { new Stoneedge() },
			[42] = new List<Move>() { new Thrash() },
			[47] = new List<Move>() { new Sandstorm() },
			[52] = new List<Move>() { new Hyperbeam() },
			[59] = new List<Move>() { new Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Assurance(), new Attract(), new Avalanche(), new Blizzard(), new Bodypress(), new Bodyslam(), new Breakingswipe(), new Brickbreak(), new Brutalswing(), new Bulldoze(), new Crunch(), new Cut(), new Darkpulse(), new Dig(), new Doubleteam(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firefang(), new Firepunch(), new Flamethrower(), new Fling(), new Focusblast(), new Focusenergy(), new Focuspunch(), new Foulplay(), new Gigaimpact(), new Heavyslam(), new Hiddenpower(), new Highhorsepower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icefang(), new Icepunch(), new Irondefense(), new Ironhead(), new Irontail(), new Lashout(), new Lowkick(), new Megakick(), new Megapunch(), new Muddywater(), new Outrage(), new Payback(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Roar(), new Rockblast(), new Rockclimb(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scaryface(), new Screech(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snarl(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Swagger(), new Taunt(), new Thunder(), new Thunderbolt(), new Thunderfang(), new Thunderpunch(), new Thunderwave(), new Torment(), new Uproar(), new Waterpulse(), new Whirlpool() };
		public override int Weight => 2020;
		public override int ExpYield => 300;
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