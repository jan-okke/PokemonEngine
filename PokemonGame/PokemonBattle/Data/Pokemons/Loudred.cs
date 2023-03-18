using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Loudred : Pokemon
	{
		public override string Name => "Loudred";
		public override List<Ability> AvailableAbilities => new() {new Soundproof() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Scrappy() };
		public override Stats BaseStats => new Stats(84, 71, 43, 48, 71, 43);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Bite() },
			[1] = new List<Move>() { new Bite(), new Astonish(), new Pound(), new Echoedvoice(), new Howl() },
			[15] = new List<Move>() { new Rest(), new Sleeptalk() },
			[23] = new List<Move>() { new Stomp() },
			[29] = new List<Move>() { new Roar() },
			[36] = new List<Move>() { new Supersonic() },
			[43] = new List<Move>() { new Uproar() },
			[50] = new List<Move>() { new Screech() },
			[57] = new List<Move>() { new Hypervoice() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Faketears(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Hiddenpower(), new Hypervoice(), new Icebeam(), new Icepunch(), new Icywind(), new Lowkick(), new Megakick(), new Megapunch(), new Overheat(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Screech(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thunderpunch(), new Torment(), new Uproar(), new Waterpulse(), new Workup(), new Zenheadbutt() };
		public override int Weight => 405;
		public override int ExpYield => 126;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}