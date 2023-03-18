using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Buizel : Pokemon
	{
		public override string Name => "Buizel";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Waterveil() };
		public override Stats BaseStats => new Stats(55, 65, 35, 85, 60, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle() },
			[4] = new List<Move>() { new Growl() },
			[7] = new List<Move>() { new Tailwhip() },
			[11] = new List<Move>() { new Quickattack() },
			[15] = new List<Move>() { new Watergun() },
			[18] = new List<Move>() { new Bite() },
			[21] = new List<Move>() { new Swift() },
			[24] = new List<Move>() { new Aquajet() },
			[27] = new List<Move>() { new Doublehit() },
			[31] = new List<Move>() { new Whirlpool() },
			[35] = new List<Move>() { new Waterfall() },
			[38] = new List<Move>() { new Aquatail() },
			[41] = new List<Move>() { new Agility() },
			[45] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aquatail(), new Attract(), new Blizzard(), new Brickbreak(), new Brine(), new Bulkup(), new Confide(), new Dig(), new Dive(), new Doubleteam(), new Echoedvoice(), new Endure(), new Facade(), new Focuspunch(), new Frustration(), new Hail(), new Helpinghand(), new Hiddenpower(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Rocksmash(), new Rocktomb(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Waterfall(), new Waterpulse() };
		public override List<Move> EggMoves => new List<Move>() { new Aquaring(), new Aquatail(), new Batonpass(), new Furycutter(), new Furyswipes(), new Headbutt(), new Helpinghand(), new Mudslap(), new Slash(), new Soak(), new Switcheroo() };
		public override int Weight => 295;
		public override int ExpYield => 66;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}