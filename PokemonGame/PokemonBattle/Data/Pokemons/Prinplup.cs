using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Prinplup : Pokemon
	{
		public override string Name => "Prinplup";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Defiant() };
		public override Stats BaseStats => new Stats(64, 66, 68, 81, 76, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Metalclaw() },
			[1] = new List<Move>() { new Metalclaw(), new Tackle(), new Growl() },
			[4] = new List<Move>() { new Growl() },
			[8] = new List<Move>() { new Watergun() },
			[11] = new List<Move>() { new Charm() },
			[15] = new List<Move>() { new Peck() },
			[19] = new List<Move>() { new Bubblebeam() },
			[24] = new List<Move>() { new Swagger() },
			[28] = new List<Move>() { new Furyattack() },
			[33] = new List<Move>() { new Brine() },
			[37] = new List<Move>() { new Whirlpool() },
			[42] = new List<Move>() { new Mist() },
			[46] = new List<Move>() { new Drillpeck() },
			[50] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Blizzard(), new Brickbreak(), new Brine(), new Confide(), new Covet(), new Cut(), new Defog(), new Dig(), new Dive(), new Doubleteam(), new Echoedvoice(), new Endure(), new Facade(), new Fling(), new Frustration(), new Grassknot(), new Hail(), new Hiddenpower(), new Icebeam(), new Icywind(), new Pluck(), new Protect(), new Quash(), new Raindance(), new Rest(), new Return(), new Rocksmash(), new Rocktomb(), new Round(), new Scald(), new Shadowclaw(), new Signalbeam(), new Sleeptalk(), new Snore(), new Stealthrock(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Waterfall(), new Waterpledge(), new Waterpulse(), new Workup() };
		public override int Weight => 230;
		public override int ExpYield => 142;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}