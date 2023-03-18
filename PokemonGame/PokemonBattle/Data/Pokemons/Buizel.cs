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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Waterveil() };
		public override Stats BaseStats => new Stats(55, 65, 35, 60, 30, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle() },
			[4] = new List<Move>() { new Moves.Growl() },
			[7] = new List<Move>() { new Moves.Tailwhip() },
			[11] = new List<Move>() { new Moves.Quickattack() },
			[15] = new List<Move>() { new Moves.Watergun() },
			[18] = new List<Move>() { new Moves.Bite() },
			[21] = new List<Move>() { new Moves.Swift() },
			[24] = new List<Move>() { new Moves.Aquajet() },
			[27] = new List<Move>() { new Moves.Doublehit() },
			[31] = new List<Move>() { new Moves.Whirlpool() },
			[35] = new List<Move>() { new Moves.Waterfall() },
			[38] = new List<Move>() { new Moves.Aquatail() },
			[41] = new List<Move>() { new Moves.Agility() },
			[45] = new List<Move>() { new Moves.Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aquatail(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Brickbreak(), new Moves.Brine(), new Moves.Bulkup(), new Moves.Confide(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Endure(), new Moves.Facade(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Waterfall(), new Moves.Waterpulse() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Aquaring(), new Moves.Aquatail(), new Moves.Batonpass(), new Moves.Furycutter(), new Moves.Furyswipes(), new Moves.Headbutt(), new Moves.Helpinghand(), new Moves.Mudslap(), new Moves.Slash(), new Moves.Soak(), new Moves.Switcheroo() };
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