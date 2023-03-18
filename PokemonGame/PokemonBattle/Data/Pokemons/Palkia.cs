using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Palkia : Pokemon
	{
		public override string Name => "Palkia";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Telepathy() };
		public override Stats BaseStats => new Stats(90, 120, 100, 100, 150, 120);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scaryface(), new Waterpulse() },
			[8] = new List<Move>() { new Dragonbreath() },
			[16] = new List<Move>() { new Ancientpower() },
			[24] = new List<Move>() { new Slash() },
			[32] = new List<Move>() { new Aquaring() },
			[40] = new List<Move>() { new Spacialrend() },
			[48] = new List<Move>() { new Dragonclaw() },
			[56] = new List<Move>() { new Aurasphere() },
			[64] = new List<Move>() { new Powergem() },
			[72] = new List<Move>() { new Aquatail() },
			[80] = new List<Move>() { new Earthpower() },
			[88] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Aurasphere(), new Avalanche(), new Blizzard(), new Bodypress(), new Bodyslam(), new Breakingswipe(), new Brickbreak(), new Brine(), new Bulkup(), new Bulldoze(), new Cut(), new Dive(), new Doubleteam(), new Dracometeor(), new Dragonclaw(), new Dragonpulse(), new Dualwingbeat(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Flamethrower(), new Fling(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Hail(), new Heavyslam(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Liquidation(), new Outrage(), new Powergem(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Scaleshot(), new Scaryface(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Trickroom(), new Waterpulse(), new Whirlpool() };
		public override int Weight => 3360;
		public override int ExpYield => 340;
		public override int CatchRate => 3;
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