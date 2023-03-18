using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Carracosta : Pokemon
	{
		public override string Name => "Carracosta";
		public override List<Ability> AvailableAbilities => new() {new Solidrock(), new Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Swiftswim() };
		public override Stats BaseStats => new Stats(74, 108, 133, 32, 83, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun(), new Withdraw(), new Protect(), new Aquajet() },
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
			[41] = new List<Move>() { new Raindance() },
			[46] = new List<Move>() { new Hydropump() },
			[51] = new List<Move>() { new Shellsmash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bodyslam(), new Brine(), new Bulldoze(), new Crunch(), new Dig(), new Dive(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Focusblast(), new Gigaimpact(), new Guardswap(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Irondefense(), new Ironhead(), new Irontail(), new Liquidation(), new Lowkick(), new Meteorbeam(), new Muddywater(), new Mudshot(), new Protect(), new Raindance(), new Razorshell(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Scald(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stoneedge(), new Substitute(), new Superpower(), new Surf(), new Waterfall(), new Whirlpool(), new Zenheadbutt() };
		public override int Weight => 810;
		public override int ExpYield => 173;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}