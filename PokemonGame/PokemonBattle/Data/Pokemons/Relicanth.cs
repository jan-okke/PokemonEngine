using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Relicanth : Pokemon
	{
		public override string Name => "Relicanth";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim(), new Rockhead() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sturdy() };
		public override Stats BaseStats => new Stats(100, 90, 130, 45, 65, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Harden() },
			[5] = new List<Move>() { new Watergun() },
			[10] = new List<Move>() { new Ancientpower() },
			[15] = new List<Move>() { new Yawn() },
			[20] = new List<Move>() { new Dive() },
			[25] = new List<Move>() { new Takedown() },
			[30] = new List<Move>() { new Aquatail() },
			[35] = new List<Move>() { new Rest() },
			[40] = new List<Move>() { new Flail() },
			[45] = new List<Move>() { new Hydropump() },
			[50] = new List<Move>() { new Doubleedge() },
			[55] = new List<Move>() { new Headsmash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Blizzard(), new Bodypress(), new Bodyslam(), new Bounce(), new Brine(), new Bulldoze(), new Calmmind(), new Dive(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Irondefense(), new Liquidation(), new Meteorbeam(), new Muddywater(), new Mudshot(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Rockblast(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Scald(), new Scaleshot(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Surf(), new Swagger(), new Waterfall(), new Waterpulse(), new Whirlpool(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Amnesia(), new Aquatail(), new Muddywater(), new Mudshot(), new Mudslap(), new Skullbash(), new Snore(), new Zenheadbutt() };
		public override int Weight => 234;
		public override int ExpYield => 170;
		public override int CatchRate => 25;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}