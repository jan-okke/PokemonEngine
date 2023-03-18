using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Totodile : Pokemon
	{
		public override string Name => "Totodile";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sheerforce() };
		public override Stats BaseStats => new Stats(50, 65, 64, 43, 44, 48);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Leer() },
			[6] = new List<Move>() { new Watergun() },
			[8] = new List<Move>() { new Mudslap() },
			[13] = new List<Move>() { new Bite() },
			[15] = new List<Move>() { new Scaryface() },
			[20] = new List<Move>() { new Icefang() },
			[22] = new List<Move>() { new Flail() },
			[27] = new List<Move>() { new Crunch() },
			[29] = new List<Move>() { new Lowkick() },
			[34] = new List<Move>() { new Slash() },
			[36] = new List<Move>() { new Screech() },
			[41] = new List<Move>() { new Thrash() },
			[43] = new List<Move>() { new Aquatail() },
			[48] = new List<Move>() { new Superpower() },
			[50] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Aquatail(), new Attract(), new Blizzard(), new Block(), new Brickbreak(), new Confide(), new Cut(), new Dig(), new Dive(), new Doubleteam(), new Dragonclaw(), new Endure(), new Facade(), new Fling(), new Focuspunch(), new Frustration(), new Hail(), new Hiddenpower(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Lowkick(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Rockslide(), new Rocktomb(), new Round(), new Scald(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Spite(), new Substitute(), new Superpower(), new Surf(), new Swagger(), new Swordsdance(), new Uproar(), new Waterfall(), new Waterpledge(), new Waterpulse(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Ancientpower(), new Aquajet(), new Block(), new Crunch(), new Dragondance(), new Faketears(), new Flatter(), new Hydropump(), new Icepunch(), new Metalclaw(), new Thrash() };
		public override int Weight => 95;
		public override int ExpYield => 63;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}