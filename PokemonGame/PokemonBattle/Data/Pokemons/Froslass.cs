using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Froslass : Pokemon
	{
		public override string Name => "Froslass";
		public override List<Ability> AvailableAbilities => new() {new Snowcloak() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Cursedbody() };
		public override Stats BaseStats => new Stats(70, 80, 70, 110, 80, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Hex() },
			[1] = new List<Move>() { new Hex(), new Destinybond(), new Protect(), new Bite(), new Icefang(), new Headbutt(), new Crunch(), new Powdersnow(), new Astonish(), new Leer(), new Doubleteam() },
			[15] = new List<Move>() { new Iceshard() },
			[20] = new List<Move>() { new Drainingkiss() },
			[25] = new List<Move>() { new Icywind() },
			[30] = new List<Move>() { new Frostbreath() },
			[35] = new List<Move>() { new Confuseray() },
			[40] = new List<Move>() { new Hail() },
			[47] = new List<Move>() { new Willowisp() },
			[54] = new List<Move>() { new Auroraveil() },
			[61] = new List<Move>() { new Shadowball() },
			[68] = new List<Move>() { new Blizzard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Avalanche(), new Blizzard(), new Bodyslam(), new Charm(), new Crunch(), new Doubleteam(), new Drainingkiss(), new Dreameater(), new Endure(), new Facade(), new Faketears(), new Flash(), new Fling(), new Gigaimpact(), new Hail(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icefang(), new Icepunch(), new Iciclespear(), new Icywind(), new Imprison(), new Lightscreen(), new Payback(), new Poltergeist(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Spikes(), new Substitute(), new Swagger(), new Taunt(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Torment(), new Trick(), new Tripleaxel(), new Waterpulse(), new Weatherball(), new Willowisp() };
		public override int Weight => 266;
		public override int ExpYield => 168;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}