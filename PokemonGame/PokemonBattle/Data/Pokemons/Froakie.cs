using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Froakie : Pokemon
	{
		public override string Name => "Froakie";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Protean() };
		public override Stats BaseStats => new Stats(41, 56, 40, 62, 44, 71);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound(), new Growl() },
			[5] = new List<Move>() { new Bubble() },
			[8] = new List<Move>() { new Quickattack() },
			[10] = new List<Move>() { new Lick() },
			[14] = new List<Move>() { new Waterpulse() },
			[18] = new List<Move>() { new Smokescreen() },
			[21] = new List<Move>() { new Round() },
			[25] = new List<Move>() { new Fling() },
			[29] = new List<Move>() { new Smackdown() },
			[35] = new List<Move>() { new Substitute() },
			[39] = new List<Move>() { new Bounce() },
			[43] = new List<Move>() { new Doubleteam() },
			[48] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Blizzard(), new Bounce(), new Confide(), new Cut(), new Dive(), new Doubleteam(), new Echoedvoice(), new Facade(), new Fling(), new Frustration(), new Grassknot(), new Hiddenpower(), new Icebeam(), new Icywind(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roleplay(), new Round(), new Scald(), new Sleeptalk(), new Smackdown(), new Snatch(), new Snore(), new Spite(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Taunt(), new Thief(), new Toxic(), new Uturn(), new Waterfall(), new Waterpledge(), new Waterpulse(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Bestow(), new Camouflage(), new Mindreader(), new Mudsport(), new Poweruppunch(), new Toxicspikes(), new Watersport() };
		public override int Weight => 70;
		public override int ExpYield => 63;
		public override int CatchRate => 45;
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