using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Slakoth : Pokemon
	{
		public override string Name => "Slakoth";
		public override List<Ability> AvailableAbilities => new() {new Truant() };
		public override Stats BaseStats => new Stats(60, 60, 60, 35, 35, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Yawn() },
			[6] = new List<Move>() { new Encore() },
			[9] = new List<Move>() { new Slackoff() },
			[14] = new List<Move>() { new Rest() },
			[17] = new List<Move>() { new Amnesia() },
			[22] = new List<Move>() { new Covet() },
			[25] = new List<Move>() { new Headbutt() },
			[30] = new List<Move>() { new Counter() },
			[33] = new List<Move>() { new Flail() },
			[38] = new List<Move>() { new Playrough() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Afteryou(), new Attract(), new Blizzard(), new Brickbreak(), new Bulkup(), new Confide(), new Covet(), new Cut(), new Doubleteam(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focuspunch(), new Frustration(), new Gunkshot(), new Hiddenpower(), new Icebeam(), new Icepunch(), new Icywind(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Waterpulse(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Afteryou(), new Bodyslam(), new Crushclaw(), new Curse(), new Hammerarm(), new Nightslash(), new Slash(), new Snore(), new Tickle() };
		public override int Weight => 240;
		public override int ExpYield => 56;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}