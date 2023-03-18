using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Charmeleon : Pokemon
	{
		public override string Name => "Charmeleon";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Solarpower() };
		public override Stats BaseStats => new Stats(58, 64, 58, 80, 80, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Growl(), new Ember(), new Smokescreen() },
			[12] = new List<Move>() { new Dragonbreath() },
			[19] = new List<Move>() { new Firefang() },
			[24] = new List<Move>() { new Slash() },
			[30] = new List<Move>() { new Flamethrower() },
			[37] = new List<Move>() { new Scaryface() },
			[42] = new List<Move>() { new Firespin() },
			[48] = new List<Move>() { new Inferno() },
			[54] = new List<Move>() { new Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Beatup(), new Bodyslam(), new Brickbreak(), new Crunch(), new Cut(), new Dig(), new Doubleteam(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Endure(), new Facade(), new Falseswipe(), new Fireblast(), new Firefang(), new Firepledge(), new Firepunch(), new Firespin(), new Flamethrower(), new Flareblitz(), new Fling(), new Focuspunch(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Megakick(), new Megapunch(), new Outrage(), new Overheat(), new Protect(), new Rest(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scaryface(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Thunderpunch(), new Weatherball(), new Willowisp(), new Workup() };
		public override int Weight => 190;
		public override int ExpYield => 142;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}