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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Protean() };
		public override Stats BaseStats => new Stats(41, 56, 40, 62, 44, 71);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Pound(), new Moves.Growl() },
			[5] = new List<Move>() { new Moves.Bubble() },
			[8] = new List<Move>() { new Moves.Quickattack() },
			[10] = new List<Move>() { new Moves.Lick() },
			[14] = new List<Move>() { new Moves.Waterpulse() },
			[18] = new List<Move>() { new Moves.Smokescreen() },
			[21] = new List<Move>() { new Moves.Round() },
			[25] = new List<Move>() { new Moves.Fling() },
			[29] = new List<Move>() { new Moves.Smackdown() },
			[35] = new List<Move>() { new Moves.Substitute() },
			[39] = new List<Move>() { new Moves.Bounce() },
			[43] = new List<Move>() { new Moves.Doubleteam() },
			[48] = new List<Move>() { new Moves.Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bounce(), new Moves.Confide(), new Moves.Cut(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Facade(), new Moves.Fling(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roleplay(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Smackdown(), new Moves.Snatch(), new Moves.Snore(), new Moves.Spite(), new Moves.Strength(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Toxic(), new Moves.Uturn(), new Moves.Waterfall(), new Moves.Waterpledge(), new Moves.Waterpulse(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Bestow(), new Moves.Camouflage(), new Moves.Mindreader(), new Moves.Mudsport(), new Moves.Poweruppunch(), new Moves.Toxicspikes(), new Moves.Watersport() };
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