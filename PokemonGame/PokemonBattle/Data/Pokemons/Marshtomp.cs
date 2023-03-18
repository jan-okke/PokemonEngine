using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Marshtomp : Pokemon
	{
		public override string Name => "Marshtomp";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Damp() };
		public override Stats BaseStats => new Stats(70, 85, 70, 50, 60, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Mudshot() },
			[1] = new List<Move>() { new Mudshot(), new Earthquake(), new Surf(), new Tackle(), new Growl(), new Watergun(), new Rocksmash() },
			[9] = new List<Move>() { new Rockthrow() },
			[12] = new List<Move>() { new Protect() },
			[15] = new List<Move>() { new Supersonic() },
			[20] = new List<Move>() { new Waterpulse() },
			[25] = new List<Move>() { new Rockslide() },
			[30] = new List<Move>() { new Takedown() },
			[35] = new List<Move>() { new Amnesia() },
			[40] = new List<Move>() { new Muddywater() },
			[45] = new List<Move>() { new Screech() },
			[50] = new List<Move>() { new Endeavor() },
			[55] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Avalanche(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Dig(), new Dive(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fling(), new Hail(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Lowkick(), new Megakick(), new Megapunch(), new Muddywater(), new Mudshot(), new Protect(), new Raindance(), new Rest(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandtomb(), new Scald(), new Screech(), new Sleeptalk(), new Sludgewave(), new Snore(), new Stealthrock(), new Strength(), new Substitute(), new Superpower(), new Surf(), new Swagger(), new Uproar(), new Waterfall(), new Waterpledge(), new Waterpulse(), new Whirlpool(), new Workup() };
		public override int Weight => 280;
		public override int ExpYield => 142;
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