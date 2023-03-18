using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Magmortar : Pokemon
	{
		public override string Name => "Magmortar";
		public override List<Ability> AvailableAbilities => new() {new Flamebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Vitalspirit() };
		public override Stats BaseStats => new Stats(75, 95, 67, 125, 95, 83);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Smog(), new Leer(), new Ember(), new Smokescreen() },
			[12] = new List<Move>() { new Clearsmog() },
			[16] = new List<Move>() { new Flamewheel() },
			[20] = new List<Move>() { new Confuseray() },
			[24] = new List<Move>() { new Scaryface() },
			[28] = new List<Move>() { new Firepunch() },
			[34] = new List<Move>() { new Lavaplume() },
			[40] = new List<Move>() { new Lowkick() },
			[46] = new List<Move>() { new Flamethrower() },
			[52] = new List<Move>() { new Sunnyday() },
			[58] = new List<Move>() { new Fireblast() },
			[64] = new List<Move>() { new Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Burningjealousy(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Firespin(), new Flamethrower(), new Flareblitz(), new Fling(), new Focusblast(), new Focusenergy(), new Focuspunch(), new Gigaimpact(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Irontail(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Mysticalfire(), new Overheat(), new Powerswap(), new Protect(), new Psychic(), new Rest(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scaryface(), new Scorchingsands(), new Screech(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thief(), new Thunderbolt(), new Thunderpunch(), new Torment(), new Uproar(), new Weatherball(), new Willowisp() };
		public override int Weight => 680;
		public override int ExpYield => 270;
		public override int CatchRate => 30;
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