using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Slaking : Pokemon
	{
		public override string Name => "Slaking";
		public override List<Ability> AvailableAbilities => new() {new Truant() };
		public override Stats BaseStats => new Stats(150, 160, 100, 95, 65, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Swagger() },
			[1] = new List<Move>() { new Swagger(), new Hammerarm(), new Fling(), new Scratch(), new Yawn(), new Encore(), new Slackoff() },
			[6] = new List<Move>() { new Encore() },
			[9] = new List<Move>() { new Slackoff() },
			[14] = new List<Move>() { new Rest() },
			[17] = new List<Move>() { new Amnesia() },
			[23] = new List<Move>() { new Covet() },
			[27] = new List<Move>() { new Headbutt() },
			[33] = new List<Move>() { new Counter() },
			[39] = new List<Move>() { new Flail() },
			[47] = new List<Move>() { new Fling() },
			[53] = new List<Move>() { new Suckerpunch() },
			[61] = new List<Move>() { new Hammerarm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Afteryou(), new Attract(), new Blizzard(), new Block(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Confide(), new Covet(), new Cut(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigaimpact(), new Gunkshot(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Icywind(), new Lowkick(), new Lowsweep(), new Poweruppunch(), new Protect(), new Quash(), new Raindance(), new Rest(), new Return(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Smackdown(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Waterpulse(), new Workup() };
		public override int Weight => 1305;
		public override int ExpYield => 285;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 3,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}