using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mudkip : Pokemon
	{
		public override string Name => "Mudkip";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Damp() };
		public override Stats BaseStats => new Stats(50, 70, 50, 50, 50, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl() },
			[3] = new List<Move>() { new Watergun() },
			[6] = new List<Move>() { new Rocksmash() },
			[9] = new List<Move>() { new Rockthrow() },
			[12] = new List<Move>() { new Protect() },
			[15] = new List<Move>() { new Supersonic() },
			[18] = new List<Move>() { new Waterpulse() },
			[21] = new List<Move>() { new Rockslide() },
			[24] = new List<Move>() { new Takedown() },
			[27] = new List<Move>() { new Amnesia() },
			[30] = new List<Move>() { new Surf() },
			[33] = new List<Move>() { new Screech() },
			[36] = new List<Move>() { new Endeavor() },
			[39] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Avalanche(), new Blizzard(), new Bodyslam(), new Dig(), new Dive(), new Doubleteam(), new Earthpower(), new Endure(), new Facade(), new Hail(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icywind(), new Irontail(), new Lowkick(), new Protect(), new Raindance(), new Rest(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scald(), new Screech(), new Sleeptalk(), new Sludgewave(), new Snore(), new Strength(), new Substitute(), new Superpower(), new Surf(), new Swagger(), new Uproar(), new Waterfall(), new Waterpledge(), new Waterpulse(), new Whirlpool(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Ancientpower(), new Bite(), new Counter(), new Curse(), new Doubleedge(), new Mirrorcoat(), new Mudslap(), new Sludge(), new Stomp(), new Uproar(), new Whirlpool(), new Wideguard(), new Yawn() };
		public override int Weight => 76;
		public override int ExpYield => 62;
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