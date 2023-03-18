using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Glalie : Pokemon
	{
		public override string Name => "Glalie";
		public override List<Ability> AvailableAbilities => new() {new Innerfocus(), new Icebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Moody() };
		public override Stats BaseStats => new Stats(80, 80, 80, 80, 80, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Freezedry() },
			[1] = new List<Move>() { new Freezedry(), new Sheercold(), new Powdersnow(), new Astonish(), new Leer(), new Doubleteam() },
			[15] = new List<Move>() { new Iceshard() },
			[20] = new List<Move>() { new Protect() },
			[25] = new List<Move>() { new Icywind() },
			[30] = new List<Move>() { new Frostbreath() },
			[35] = new List<Move>() { new Bite() },
			[40] = new List<Move>() { new Icefang() },
			[47] = new List<Move>() { new Hail() },
			[54] = new List<Move>() { new Headbutt() },
			[61] = new List<Move>() { new Crunch() },
			[68] = new List<Move>() { new Blizzard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Avalanche(), new Blizzard(), new Bodyslam(), new Bulldoze(), new Crunch(), new Darkpulse(), new Doubleteam(), new Earthquake(), new Endure(), new Explosion(), new Facade(), new Faketears(), new Flash(), new Gigaimpact(), new Gyroball(), new Hail(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icefang(), new Iciclespear(), new Icywind(), new Ironhead(), new Lightscreen(), new Payback(), new Protect(), new Raindance(), new Rest(), new Round(), new Safeguard(), new Scaryface(), new Selfdestruct(), new Shadowball(), new Sleeptalk(), new Snore(), new Spikes(), new Steelroller(), new Substitute(), new Swagger(), new Taunt(), new Torment(), new Waterpulse(), new Weatherball() };
		public override int Weight => 2565;
		public override int ExpYield => 168;
		public override int CatchRate => 75;
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