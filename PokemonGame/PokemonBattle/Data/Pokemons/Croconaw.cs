using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Croconaw : Pokemon
	{
		public override string Name => "Croconaw";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sheerforce() };
		public override Stats BaseStats => new Stats(65, 80, 80, 59, 63, 58);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Leer(), new Watergun() },
			[6] = new List<Move>() { new Watergun() },
			[8] = new List<Move>() { new Mudslap() },
			[13] = new List<Move>() { new Bite() },
			[15] = new List<Move>() { new Scaryface() },
			[21] = new List<Move>() { new Icefang() },
			[24] = new List<Move>() { new Flail() },
			[30] = new List<Move>() { new Crunch() },
			[33] = new List<Move>() { new Lowkick() },
			[39] = new List<Move>() { new Slash() },
			[42] = new List<Move>() { new Screech() },
			[48] = new List<Move>() { new Thrash() },
			[51] = new List<Move>() { new Aquatail() },
			[57] = new List<Move>() { new Superpower() },
			[60] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Aquatail(), new Attract(), new Blizzard(), new Block(), new Brickbreak(), new Confide(), new Cut(), new Dig(), new Dive(), new Doubleteam(), new Dragonclaw(), new Endure(), new Facade(), new Fling(), new Focuspunch(), new Frustration(), new Hail(), new Hiddenpower(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Lowkick(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scald(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Spite(), new Strength(), new Substitute(), new Superpower(), new Surf(), new Swagger(), new Swordsdance(), new Uproar(), new Waterfall(), new Waterpledge(), new Waterpulse(), new Workup() };
		public override int Weight => 250;
		public override int ExpYield => 142;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}