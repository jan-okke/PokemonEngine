using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dialga : Pokemon
	{
		public override string Name => "Dialga";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Telepathy() };
		public override Stats BaseStats => new Stats(100, 120, 120, 150, 100, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scaryface(), new Metalclaw() },
			[8] = new List<Move>() { new Dragonbreath() },
			[16] = new List<Move>() { new Ancientpower() },
			[24] = new List<Move>() { new Slash() },
			[32] = new List<Move>() { new Flashcannon() },
			[40] = new List<Move>() { new Roaroftime() },
			[48] = new List<Move>() { new Dragonclaw() },
			[56] = new List<Move>() { new Aurasphere() },
			[64] = new List<Move>() { new Powergem() },
			[72] = new List<Move>() { new Metalburst() },
			[80] = new List<Move>() { new Earthpower() },
			[88] = new List<Move>() { new Irontail() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Aurasphere(), new Blizzard(), new Bodypress(), new Bodyslam(), new Breakingswipe(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Cut(), new Doubleteam(), new Dracometeor(), new Dragonclaw(), new Dragonpulse(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Flamethrower(), new Flash(), new Flashcannon(), new Gigaimpact(), new Heavyslam(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Irondefense(), new Ironhead(), new Irontail(), new Outrage(), new Overheat(), new Powergem(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Scaleshot(), new Scaryface(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snore(), new Stealthrock(), new Steelbeam(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Trickroom() };
		public override int Weight => 6830;
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