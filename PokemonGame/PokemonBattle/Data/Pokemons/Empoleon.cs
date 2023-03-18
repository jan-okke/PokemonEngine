using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Empoleon : Pokemon
	{
		public override string Name => "Empoleon";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Defiant() };
		public override Stats BaseStats => new Stats(84, 86, 88, 60, 111, 101);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Aquajet() },
			[1] = new List<Move>() { new Aquajet(), new Metalclaw(), new Tackle(), new Growl() },
			[4] = new List<Move>() { new Growl() },
			[8] = new List<Move>() { new Watergun() },
			[11] = new List<Move>() { new Swordsdance() },
			[15] = new List<Move>() { new Peck() },
			[19] = new List<Move>() { new Bubblebeam() },
			[24] = new List<Move>() { new Swagger() },
			[28] = new List<Move>() { new Furyattack() },
			[33] = new List<Move>() { new Brine() },
			[39] = new List<Move>() { new Whirlpool() },
			[46] = new List<Move>() { new Mist() },
			[52] = new List<Move>() { new Drillpeck() },
			[59] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Avalanche(), new Blizzard(), new Brickbreak(), new Brine(), new Bulldoze(), new Confide(), new Covet(), new Cut(), new Defog(), new Dig(), new Dive(), new Doubleteam(), new Earthquake(), new Echoedvoice(), new Endure(), new Facade(), new Flashcannon(), new Fling(), new Frustration(), new Gigaimpact(), new Grassknot(), new Hail(), new Hiddenpower(), new Hydrocannon(), new Hyperbeam(), new Icebeam(), new Icywind(), new Irondefense(), new Knockoff(), new Laserfocus(), new Liquidation(), new Pluck(), new Protect(), new Quash(), new Raindance(), new Rest(), new Return(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scald(), new Shadowclaw(), new Signalbeam(), new Sleeptalk(), new Snore(), new Stealthrock(), new Steelwing(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Swordsdance(), new Throatchop(), new Waterfall(), new Waterpledge(), new Waterpulse(), new Workup() };
		public override int Weight => 845;
		public override int ExpYield => 265;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}