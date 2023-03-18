using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Magby : Pokemon
	{
		public override string Name => "Magby";
		public override List<Ability> AvailableAbilities => new() {new Flamebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Vitalspirit() };
		public override Stats BaseStats => new Stats(45, 75, 37, 83, 70, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Smog(), new Leer() },
			[4] = new List<Move>() { new Ember() },
			[8] = new List<Move>() { new Smokescreen() },
			[12] = new List<Move>() { new Clearsmog() },
			[16] = new List<Move>() { new Flamewheel() },
			[20] = new List<Move>() { new Confuseray() },
			[24] = new List<Move>() { new Scaryface() },
			[28] = new List<Move>() { new Firepunch() },
			[32] = new List<Move>() { new Lavaplume() },
			[36] = new List<Move>() { new Lowkick() },
			[40] = new List<Move>() { new Flamethrower() },
			[44] = new List<Move>() { new Sunnyday() },
			[48] = new List<Move>() { new Fireblast() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Brickbreak(), new Doubleteam(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Firespin(), new Flamethrower(), new Flareblitz(), new Fling(), new Focusenergy(), new Focuspunch(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Lowkick(), new Megakick(), new Megapunch(), new Overheat(), new Powerswap(), new Protect(), new Psychic(), new Rest(), new Rocksmash(), new Round(), new Scaryface(), new Screech(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Thief(), new Thunderpunch(), new Uproar(), new Willowisp() };
		public override List<Move> EggMoves => new List<Move>() { new Belch(), new Bellydrum(), new Crosschop(), new Dynamicpunch(), new Flareblitz(), new Focusenergy(), new Machpunch(), new Megapunch(), new Powerswap(), new Screech(), new Thunderpunch() };
		public override int Weight => 214;
		public override int ExpYield => 73;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}