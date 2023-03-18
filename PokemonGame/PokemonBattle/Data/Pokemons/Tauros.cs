using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tauros : Pokemon
	{
		public override string Name => "Tauros";
		public override List<Ability> AvailableAbilities => new() {new Intimidate(), new Angerpoint() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sheerforce() };
		public override Stats BaseStats => new Stats(75, 100, 95, 110, 40, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Tailwhip() },
			[5] = new List<Move>() { new Workup() },
			[10] = new List<Move>() { new Payback() },
			[15] = new List<Move>() { new Assurance() },
			[20] = new List<Move>() { new Hornattack() },
			[25] = new List<Move>() { new Scaryface() },
			[30] = new List<Move>() { new Zenheadbutt() },
			[35] = new List<Move>() { new Takedown() },
			[40] = new List<Move>() { new Rest() },
			[45] = new List<Move>() { new Swagger() },
			[50] = new List<Move>() { new Thrash() },
			[55] = new List<Move>() { new Doubleedge() },
			[60] = new List<Move>() { new Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Blizzard(), new Bodyslam(), new Bulldoze(), new Closecombat(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Flamethrower(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Ironhead(), new Irontail(), new Lashout(), new Megahorn(), new Outrage(), new Payback(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Scaryface(), new Shockwave(), new Sleeptalk(), new Smartstrike(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Throatchop(), new Thunder(), new Thunderbolt(), new Uproar(), new Waterpulse(), new Whirlpool(), new Wildcharge(), new Workup(), new Zenheadbutt() };
		public override int Weight => 884;
		public override int ExpYield => 172;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}