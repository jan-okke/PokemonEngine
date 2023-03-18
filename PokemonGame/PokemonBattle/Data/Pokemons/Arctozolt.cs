using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Arctozolt : Pokemon
	{
		public override string Name => "Arctozolt";
		public override List<Ability> AvailableAbilities => new() {new Voltabsorb(), new Static() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Slushrush() };
		public override Stats BaseStats => new Stats(90, 100, 90, 55, 90, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Powdersnow(), new Thundershock() },
			[7] = new List<Move>() { new Charge() },
			[14] = new List<Move>() { new Echoedvoice() },
			[21] = new List<Move>() { new Ancientpower() },
			[28] = new List<Move>() { new Pluck() },
			[35] = new List<Move>() { new Avalanche() },
			[42] = new List<Move>() { new Freezedry() },
			[49] = new List<Move>() { new Slam() },
			[56] = new List<Move>() { new Discharge() },
			[63] = new List<Move>() { new Boltbeak() },
			[70] = new List<Move>() { new Iciclecrash() },
			[77] = new List<Move>() { new Blizzard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Avalanche(), new Blizzard(), new Bodyslam(), new Bulldoze(), new Electroball(), new Endure(), new Facade(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icefang(), new Iciclespear(), new Icywind(), new Irontail(), new Lowkick(), new Megakick(), new Megapunch(), new Meteorbeam(), new Payback(), new Protect(), new Raindance(), new Rest(), new Risingvoltage(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Surf(), new Taunt(), new Thunder(), new Thunderbolt(), new Thunderfang(), new Thunderpunch(), new Thunderwave(), new Wildcharge() };
		public override int Weight => 1500;
		public override int ExpYield => 177;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}