using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Frogadier : Pokemon
	{
		public override string Name => "Frogadier";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Protean() };
		public override Stats BaseStats => new Stats(54, 63, 52, 97, 83, 56);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound(), new Growl(), new Bubble() },
			[5] = new List<Move>() { new Bubble() },
			[8] = new List<Move>() { new Quickattack() },
			[10] = new List<Move>() { new Lick() },
			[14] = new List<Move>() { new Waterpulse() },
			[19] = new List<Move>() { new Smokescreen() },
			[23] = new List<Move>() { new Round() },
			[28] = new List<Move>() { new Fling() },
			[33] = new List<Move>() { new Smackdown() },
			[40] = new List<Move>() { new Substitute() },
			[45] = new List<Move>() { new Bounce() },
			[50] = new List<Move>() { new Doubleteam() },
			[56] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Blizzard(), new Bounce(), new Confide(), new Cut(), new Darkpulse(), new Dive(), new Doubleteam(), new Echoedvoice(), new Facade(), new Fling(), new Frustration(), new Grassknot(), new Gunkshot(), new Hiddenpower(), new Icebeam(), new Icepunch(), new Icywind(), new Lowkick(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roleplay(), new Round(), new Scald(), new Sleeptalk(), new Smackdown(), new Snatch(), new Snore(), new Spite(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Taunt(), new Thief(), new Toxic(), new Uturn(), new Waterfall(), new Waterpledge(), new Waterpulse(), new Workup() };
		public override int Weight => 109;
		public override int ExpYield => 142;
		public override int CatchRate => 45;
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