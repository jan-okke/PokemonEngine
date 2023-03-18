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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Innerfocus(), new Abilities.Icebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moody() };
		public override Stats BaseStats => new Stats(80, 80, 80, 80, 80, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Freezedry() },
			[1] = new List<Move>() { new Moves.Freezedry(), new Moves.Sheercold(), new Moves.Powdersnow(), new Moves.Astonish(), new Moves.Leer(), new Moves.Doubleteam() },
			[15] = new List<Move>() { new Moves.Iceshard() },
			[20] = new List<Move>() { new Moves.Protect() },
			[25] = new List<Move>() { new Moves.Icywind() },
			[30] = new List<Move>() { new Moves.Frostbreath() },
			[35] = new List<Move>() { new Moves.Bite() },
			[40] = new List<Move>() { new Moves.Icefang() },
			[47] = new List<Move>() { new Moves.Hail() },
			[54] = new List<Move>() { new Moves.Headbutt() },
			[61] = new List<Move>() { new Moves.Crunch() },
			[68] = new List<Move>() { new Moves.Blizzard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Faketears(), new Moves.Flash(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Hail(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Ironhead(), new Moves.Lightscreen(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scaryface(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Spikes(), new Moves.Steelroller(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Torment(), new Moves.Waterpulse(), new Moves.Weatherball() };
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