using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Aurorus : Pokemon
	{
		public override string Name => "Aurorus";
		public override List<Ability> AvailableAbilities => new() {new Refrigerate() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Snowwarning() };
		public override Stats BaseStats => new Stats(123, 77, 72, 58, 99, 92);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Powdersnow(), new Growl(), new Encore(), new Ancientpower() },
			[12] = new List<Move>() { new Icywind() },
			[16] = new List<Move>() { new Round() },
			[20] = new List<Move>() { new Mist() },
			[24] = new List<Move>() { new Aurorabeam() },
			[28] = new List<Move>() { new Thunderwave() },
			[32] = new List<Move>() { new Naturepower() },
			[36] = new List<Move>() { new Freezedry() },
			[42] = new List<Move>() { new Icebeam() },
			[48] = new List<Move>() { new Lightscreen() },
			[54] = new List<Move>() { new Hail() },
			[60] = new List<Move>() { new Blizzard() },
			[66] = new List<Move>() { new Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Avalanche(), new Blizzard(), new Bodyslam(), new Bulldoze(), new Calmmind(), new Darkpulse(), new Earthpower(), new Earthquake(), new Encore(), new Endure(), new Facade(), new Flashcannon(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Iciclespear(), new Icywind(), new Irondefense(), new Ironhead(), new Irontail(), new Lightscreen(), new Meteorbeam(), new Mudshot(), new Outrage(), new Protect(), new Psychic(), new Raindance(), new Reflect(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stoneedge(), new Substitute(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Weatherball(), new Zenheadbutt() };
		public override int Weight => 2250;
		public override int ExpYield => 104;
		public override int CatchRate => 45;
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