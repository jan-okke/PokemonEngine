using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Wartortle : Pokemon
	{
		public override string Name => "Wartortle";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Raindish() };
		public override Stats BaseStats => new Stats(59, 63, 80, 58, 65, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Tailwhip(), new Watergun(), new Withdraw() },
			[9] = new List<Move>() { new Rapidspin() },
			[12] = new List<Move>() { new Bite() },
			[15] = new List<Move>() { new Waterpulse() },
			[20] = new List<Move>() { new Protect() },
			[25] = new List<Move>() { new Raindance() },
			[30] = new List<Move>() { new Aquatail() },
			[35] = new List<Move>() { new Shellsmash() },
			[40] = new List<Move>() { new Irondefense() },
			[45] = new List<Move>() { new Hydropump() },
			[50] = new List<Move>() { new Skullbash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Aurasphere(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Brine(), new Dig(), new Dive(), new Doubleteam(), new Dragonpulse(), new Endure(), new Facade(), new Falseswipe(), new Fling(), new Flipturn(), new Focuspunch(), new Gyroball(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icepunch(), new Icywind(), new Irondefense(), new Irontail(), new Megakick(), new Megapunch(), new Muddywater(), new Protect(), new Raindance(), new Rest(), new Rocksmash(), new Rocktomb(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Waterfall(), new Waterpledge(), new Waterpulse(), new Weatherball(), new Whirlpool(), new Workup(), new Zenheadbutt() };
		public override int Weight => 225;
		public override int ExpYield => 142;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}