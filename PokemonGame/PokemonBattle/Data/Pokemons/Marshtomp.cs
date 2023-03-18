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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Damp() };
		public override Stats BaseStats => new Stats(70, 85, 70, 60, 70, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Mudshot() },
			[1] = new List<Move>() { new Moves.Mudshot(), new Moves.Earthquake(), new Moves.Surf(), new Moves.Tackle(), new Moves.Growl(), new Moves.Watergun(), new Moves.Rocksmash() },
			[9] = new List<Move>() { new Moves.Rockthrow() },
			[12] = new List<Move>() { new Moves.Protect() },
			[15] = new List<Move>() { new Moves.Supersonic() },
			[20] = new List<Move>() { new Moves.Waterpulse() },
			[25] = new List<Move>() { new Moves.Rockslide() },
			[30] = new List<Move>() { new Moves.Takedown() },
			[35] = new List<Move>() { new Moves.Amnesia() },
			[40] = new List<Move>() { new Moves.Muddywater() },
			[45] = new List<Move>() { new Moves.Screech() },
			[50] = new List<Move>() { new Moves.Endeavor() },
			[55] = new List<Move>() { new Moves.Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandtomb(), new Moves.Scald(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Strength(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Uproar(), new Moves.Waterfall(), new Moves.Waterpledge(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Workup() };
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