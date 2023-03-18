using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Vigoroth : Pokemon
	{
		public override string Name => "Vigoroth";
		public override List<Ability> AvailableAbilities => new() {new Vitalspirit() };
		public override Stats BaseStats => new Stats(80, 80, 80, 90, 55, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Reversal(), new Scratch(), new Focusenergy(), new Encore(), new Uproar() },
			[6] = new List<Move>() { new Encore() },
			[9] = new List<Move>() { new Uproar() },
			[14] = new List<Move>() { new Furyswipes() },
			[17] = new List<Move>() { new Endure() },
			[23] = new List<Move>() { new Slash() },
			[27] = new List<Move>() { new Headbutt() },
			[33] = new List<Move>() { new Counter() },
			[37] = new List<Move>() { new Focuspunch() },
			[43] = new List<Move>() { new Reversal() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Afteryou(), new Attract(), new Blizzard(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Confide(), new Covet(), new Cut(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gunkshot(), new Hiddenpower(), new Icebeam(), new Icepunch(), new Icywind(), new Lowkick(), new Lowsweep(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Uproar(), new Waterpulse(), new Workup() };
		public override int Weight => 465;
		public override int ExpYield => 154;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}