using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Magmar : Pokemon
	{
		public override string Name => "Magmar";
		public override List<Ability> AvailableAbilities => new() {new Flamebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Vitalspirit() };
		public override Stats BaseStats => new Stats(65, 95, 57, 100, 85, 93);
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
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Brickbreak(), new Burningjealousy(), new Doubleteam(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Firespin(), new Flamethrower(), new Flareblitz(), new Fling(), new Focusblast(), new Focusenergy(), new Focuspunch(), new Gigaimpact(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Irontail(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Overheat(), new Powerswap(), new Protect(), new Psychic(), new Rest(), new Rockclimb(), new Rocksmash(), new Round(), new Scaryface(), new Scorchingsands(), new Screech(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Thief(), new Thunderpunch(), new Uproar(), new Willowisp() };
		public override int Weight => 445;
		public override int ExpYield => 173;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}