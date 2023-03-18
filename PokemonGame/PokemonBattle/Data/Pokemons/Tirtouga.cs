using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tirtouga : Pokemon
	{
		public override string Name => "Tirtouga";
		public override List<Ability> AvailableAbilities => new() {new Solidrock(), new Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Swiftswim() };
		public override Stats BaseStats => new Stats(54, 78, 103, 53, 45, 22);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun(), new Withdraw() },
			[3] = new List<Move>() { new Protect() },
			[6] = new List<Move>() { new Aquajet() },
			[9] = new List<Move>() { new Smackdown() },
			[12] = new List<Move>() { new Ancientpower() },
			[15] = new List<Move>() { new Bite() },
			[18] = new List<Move>() { new Wideguard() },
			[21] = new List<Move>() { new Brine() },
			[24] = new List<Move>() { new Rockslide() },
			[27] = new List<Move>() { new Crunch() },
			[30] = new List<Move>() { new Curse() },
			[33] = new List<Move>() { new Irondefense() },
			[36] = new List<Move>() { new Aquatail() },
			[39] = new List<Move>() { new Raindance() },
			[42] = new List<Move>() { new Hydropump() },
			[45] = new List<Move>() { new Shellsmash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bodyslam(), new Brine(), new Bulldoze(), new Crunch(), new Dig(), new Dive(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Guardswap(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icywind(), new Irondefense(), new Irontail(), new Liquidation(), new Meteorbeam(), new Muddywater(), new Mudshot(), new Protect(), new Raindance(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Scald(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stoneedge(), new Substitute(), new Surf(), new Waterfall(), new Whirlpool(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Block(), new Knockoff(), new Rockthrow(), new Rollout(), new Slam(), new Waterpulse() };
		public override int Weight => 165;
		public override int ExpYield => 71;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}