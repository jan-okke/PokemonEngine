using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Amaura : Pokemon
	{
		public override string Name => "Amaura";
		public override List<Ability> AvailableAbilities => new() {new Refrigerate() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Snowwarning() };
		public override Stats BaseStats => new Stats(77, 59, 50, 46, 67, 63);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Powdersnow(), new Growl() },
			[4] = new List<Move>() { new Encore() },
			[8] = new List<Move>() { new Ancientpower() },
			[12] = new List<Move>() { new Icywind() },
			[16] = new List<Move>() { new Round() },
			[20] = new List<Move>() { new Mist() },
			[24] = new List<Move>() { new Aurorabeam() },
			[28] = new List<Move>() { new Thunderwave() },
			[32] = new List<Move>() { new Naturepower() },
			[36] = new List<Move>() { new Freezedry() },
			[40] = new List<Move>() { new Icebeam() },
			[44] = new List<Move>() { new Lightscreen() },
			[48] = new List<Move>() { new Hail() },
			[52] = new List<Move>() { new Blizzard() },
			[56] = new List<Move>() { new Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Avalanche(), new Blizzard(), new Bodyslam(), new Bulldoze(), new Calmmind(), new Darkpulse(), new Earthpower(), new Encore(), new Endure(), new Facade(), new Flashcannon(), new Hail(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icywind(), new Irondefense(), new Ironhead(), new Irontail(), new Lightscreen(), new Meteorbeam(), new Mudshot(), new Outrage(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stoneedge(), new Substitute(), new Thunderbolt(), new Thunderwave(), new Weatherball(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Auroraveil(), new Discharge(), new Haze(), new Mirrorcoat(), new Rockthrow(), new Takedown() };
		public override int Weight => 252;
		public override int ExpYield => 72;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}